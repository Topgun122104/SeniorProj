using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace RailRoadSignal.Database
{
    public class DatabaseConnection
    {

        private string serverName;
        private uint port;
        private string databaseName;
        private string UID;
        private string password;
        private MySqlConnectionStringBuilder connString = new MySqlConnectionStringBuilder();
        private MySqlConnection conn;
        public DatabaseConnection(string serverName, uint port, string databaseName, string UID, string password)
        {
            this.serverName = serverName;
            this.port = port;
            this.databaseName = databaseName;
            this.UID = UID;
            this.password = password;

            //create the connection object using a string builder
            connString.Server = this.serverName;
            connString.Port = this.port;
            connString.UserID = this.UID;
            connString.Password = this.password;
            connString.Database = this.databaseName;

            conn = new MySqlConnection(connString.ToString());
        }

        public void openConnection()
        {
            conn.Open();
        }
        public void closeConnection()
        {
            conn.Close();
        }

        public MySqlConnection getConnection()
        {
            return this.conn;
        }
    }
}
