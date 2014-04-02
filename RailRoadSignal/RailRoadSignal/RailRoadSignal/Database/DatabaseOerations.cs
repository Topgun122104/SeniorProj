using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using RailRoadSignal.Database;
using RailRoadSignal.Files;
using MySql.Data.MySqlClient;


namespace RailRoadSignal.Database
{
    public class DatabaseOerations
    {
        public void insertIntoDb(TrackSegment obj)
        {
            DatabaseConnection conn = new DatabaseConnection("andrew.cs.fit.edu", 3306, "signalblockdesign", "signalblockdesig", "E2SnzbV922m6R51");
            Query q = new Query();
            StringBuilder sb = new StringBuilder();
            sb.Append("insert into TrackSegment (segmenNumber, grade, )");
            try
            {
                conn.openConnection();

            }

        }
    }
}
