using MySql.Data.MySqlClient;
using Signal_Block_Design_Tool.Files;
using System.Text;

namespace Signal_Block_Design_Tool.Database
{
    static class DatabaseOperations
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmd"></param>
        /// <param name="obj"></param>
        public static void InsertIntoDatabase(DatabaseConnection conn, MySqlCommand cmd, TrackSegment obj)
        {

            cmd.CommandText = @"Insert into trackSegment
                        (trackCircuit, trackNumber, fromDist, 
                        toDist, worstCaseGrade, maxEntrySpeed, overSpeed, 
                        vehicleAccel, reactionTime, brakeRate, runwayAccelSec, 
                        propulsion, buildUpBrake, overhangDist)
                        values(@trackCircuit, @trackNumber, @fromDist, 
                        @toDist, @worstCaseGrade, @maxEntrySpeed, @overSpeed, 
                        @vehicleAccel, @reactionTime, @brakeRate, @runwayAccelSec, 
                        @propulsion, @buildUpBrake, @overhangDist)";
            cmd.Parameters.AddWithValue("@trackCircuit", obj.TrackCircuit);
            cmd.Parameters.AddWithValue("@trackNumber", obj.TrackID);
            cmd.Parameters.AddWithValue("@fromDist", obj.StartPoint);
            cmd.Parameters.AddWithValue("@toDist", obj.EndPoint);
            cmd.Parameters.AddWithValue("@worstCaseGrade", obj.GradeWorst);
            cmd.Parameters.AddWithValue("@maxEntrySpeed", obj.SpeedMax);
            cmd.Parameters.AddWithValue("@overSpeed", obj.OverSpeed);
            cmd.Parameters.AddWithValue("@vehicleAccel", obj.VehicleAccel);
            cmd.Parameters.AddWithValue("@reactionTime", obj.ReactionTime);
            cmd.Parameters.AddWithValue("@brakeRate", obj.BrakeRate);
            cmd.Parameters.AddWithValue("@runwayAccelSec", obj.RunwayAccelSec);
            cmd.Parameters.AddWithValue("@propulsion", obj.PropulsionRemSec);
            cmd.Parameters.AddWithValue("@buildUpBrake", obj.BrakeBuildUpSec);
            cmd.Parameters.AddWithValue("@overhangDist", obj.OverhangDist);
            cmd.ExecuteNonQuery();

        }

        public static void removeFromDatabase(DatabaseConnection conn, Query q, TrackSegment obj)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Delete from trackSegment where trackCircuit = @trackCircuit, trackNumber = @trackCircuit, fromDist = @fromDist,");
            sb.Append(" toDist = @toDist, worstCaseGrade = @worstCaseGrade, maxEntrySpeed = @maxEntrySpeed, overSpeed = @overSpeed,");
            sb.Append("vehicleAccel = @vehicleAccel, reactionTime = @reactionTime, brakeRate = @brakeRate, runwayAccelSec = @runwayAccelSec,");
            sb.Append("propulsion = @propulsion, buildUpBrake = @buildUpBrake, overhangDist = @overhangDist");

            MySqlCommand cmd = new MySqlCommand(sb.ToString());
            cmd.CommandText = "Delete from trackSegment where trackCircuit = @trackCircuit, trackNumber = @trackCircuit, fromDist = @fromDist, toDist = @toDist, worstCaseGrade = @worstCaseGrade";
            cmd.Parameters.AddWithValue("@trackCircuit", obj.TrackCircuit);
            cmd.Parameters.AddWithValue("@trackNumber", obj.TrackID);
            cmd.Parameters.AddWithValue("@fromDist", obj.StartPoint);
            cmd.Parameters.AddWithValue("@toDist", obj.EndPoint);
            cmd.Parameters.AddWithValue("@worstCaseGrade", obj.GradeWorst);
            cmd.Parameters.AddWithValue("@maxEntrySpeed", obj.SpeedMax);
            cmd.Parameters.AddWithValue("@overSpeed", obj.OverSpeed);
            cmd.Parameters.AddWithValue("@vehicleAccel", obj.VehicleAccel);
            cmd.Parameters.AddWithValue("@reactionTime", obj.ReactionTime);
            cmd.Parameters.AddWithValue("@brakeRate", obj.BrakeRate);
            cmd.Parameters.AddWithValue("@runwayAccelSec", obj.RunwayAccelSec);
            cmd.Parameters.AddWithValue("@propulsion", obj.PropulsionRemSec);
            cmd.Parameters.AddWithValue("@buildUpBrake", obj.BrakeBuildUpSec);
            cmd.Parameters.AddWithValue("@overhangDist", obj.OverhangDist);
     
            q.runQuery(conn, cmd);

        }


    }
}

