using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace RailRoadSignal.Files
{
    class SocketConnection
    {
        public static Socket ConnectSocket(string server, int port)
        {
            Socket sock = null;
            IPHostEntry hostEntry = null;

            // get host related information
            hostEntry = Dns.GetHostEntry(server);

            // loop through the Address list to obtain the supported AddressFamily. This is to avoid 
            // an exception that occurs when the host IP Address is not compatable with the address family
            // (typical in the IPv6 case)
            foreach (IPAddress address in hostEntry.AddressList)
            {
                IPEndPoint endpoint = new IPEndPoint(address, port);
                Socket temp = new Socket(endpoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                temp.Connect(endpoint);

                if (temp.Connected)
                {
                    sock = temp;
                    break;
                }
                else
                {
                    continue;
                }
            }
            return sock;
        }

        public static string SocketSendRecieve(string server, int port)
        {
            string request = "GET / HTTP/1.1\r\nHost: " + server + "\r\nConnection: Close\r\n\r\n";
            Byte[] bytesSent = Encoding.ASCII.GetBytes(request);
            Byte[] bytesReceived = new Byte[256];

            // Create a socket connection with the specified server and port
            Socket sock = ConnectSocket(server, port);

            if (sock == null)
            {
                return ("Connection failed");
            }

            // send request to the server
            sock.Send(bytesSent, bytesSent.Length, 0);

            // Receive the server home page content
            int bytes = 0;
            string page = "Default HTML page on " + server + ":\r\n";

            // the following will block until the page is transmitted
            do
            {
                bytes = sock.Receive(bytesReceived, bytesReceived.Length, 0);
                page = page + Encoding.ASCII.GetString(bytesReceived, 0, bytes);
            }
            while (bytes > 0);

            return page;

        }

        // Example of how to use
        /*
        static void Main(string[] args)
        {
            string host;
            int port = 80;

            if (args.Length == 0)
            {
                host = Dns.GetHostName();
            }

            else
            {
                host = args[0];
            }
            string result = SocketSendRecieve(host, port);
            Console.WriteLine(result);
        }
         * */

    }
}
