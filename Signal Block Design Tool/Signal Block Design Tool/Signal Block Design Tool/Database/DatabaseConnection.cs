using MySql.Data.MySqlClient;


namespace Signal_Block_Design_Tool.Database
{
    public class DatabaseConnection
    {
        /// <summary>
        /// 
        /// </summary>
        private string ServerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        private uint Port { get; set; }

        /// <summary>
        /// 
        /// </summary>
        private string DatabaseName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        private string UID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        private string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        private MySqlConnectionStringBuilder connString = new MySqlConnectionStringBuilder();

        /// <summary>
        /// 
        /// </summary>
        private MySqlConnection conn;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serverName"></param>
        /// <param name="port"></param>
        /// <param name="databaseName"></param>
        /// <param name="uid"></param>
        /// <param name="password"></param>
        public DatabaseConnection(string serverName, uint port, string databaseName, string uid, string password)
        {
            ServerName = serverName;
            Port = port;
            DatabaseName = databaseName;
            UID = uid;
            Password = password;

            //create the connection object using a string builder
            connString.Server = ServerName;
            connString.Port = Port;
            connString.UserID = UID;
            connString.Password = Password;
            connString.Database = DatabaseName;

            conn = new MySqlConnection(connString.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        public void openConnection()
        {
            conn.Open();
        }

        /// <summary>
        /// 
        /// </summary>
        public void closeConnection()
        {
            conn.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public MySqlConnection getConnection()
        {
            return this.conn;
        }
    }
}
