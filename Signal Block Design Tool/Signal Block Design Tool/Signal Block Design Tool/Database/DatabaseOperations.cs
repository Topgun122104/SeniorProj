using MySql.Data.MySqlClient;
using Signal_Block_Design_Tool.Files;

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

            cmd.CommandText = "Insert into trackSegment(trackCircuit, trackNumber, fromDist, toDist, worstCaseGrade, maxEntrySpeed, overSpeed, vehicleAccel, reactionTime, brakeRate, runwayAccelSec, propulsion, buildUpBrake, overhangDist) values(@trackCircuit, @trackNumber, @fromDist, @toDist, @worstCaseGrade, @maxEntrySpeed, @overSpeed, @vehicleAccel, @reactionTime, @brakeRate, @runwayAccelSec, @propulsion, @buildUpBrake, @overhangDist)";
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


    }
}

