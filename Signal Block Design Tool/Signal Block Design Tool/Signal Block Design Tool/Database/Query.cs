using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Signal_Block_Design_Tool.Database
{
    class Query
    {
        MySqlCommand cmd;
        string queryText;

        public Query()
        {
            cmd = new MySqlCommand();
            queryText = null;
        }


        public Query(string queryText)
        {
            this.queryText = queryText;
            cmd = new MySqlCommand(queryText);
        }

        public void runQuery(DatabaseConnection db_connection, MySqlCommand cmd)
        {
            try
            {
                db_connection.openConnection();

                MySqlDataReader reader = cmd.ExecuteReader();
                string row = null;
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row += reader.GetValue(i).ToString();
                    }
                    Console.WriteLine(row);

                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                if (db_connection != null)
                {
                    db_connection.closeConnection();
                }

            }

        }
        //public void runQuery(DatabaseConnection db_connection, string queryText)
        //{

        //    db_connection.openConnection();

        //    MySqlCommand cmd = db_connection.getConnection().CreateCommand();
        //    cmd.CommandText = queryText;
        //    MySqlDataReader reader = cmd.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        string row = "";
        //        for (int i = 0; i < reader.FieldCount; i++)
        //            row += reader.GetValue(i).ToString() + ", ";
        //        Console.WriteLine(row);
        //    }
        //    db_connection.closeConnection();

        //}

        public List<string> runQuery(DatabaseConnection db_connection, string queryText)
        {
            List<string> result = new List<string>();
            db_connection.openConnection();

            MySqlCommand cmd = db_connection.getConnection().CreateCommand();
            cmd.CommandText = queryText;
            MySqlDataReader reader = cmd.ExecuteReader();

            // string row = "";
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    result.Add(reader.GetValue(i).ToString());
                // result.Add(row);
            }

            db_connection.closeConnection();

            return result;


        }
    }
}
