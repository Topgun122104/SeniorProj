using MySql.Data.MySqlClient;
using Signal_Block_Design_Tool.Files;
using System.Text;

namespace Signal_Block_Design_Tool.Database
{
    static class DatabaseOperations
    {

        /// <summary>
        ///  Clears the database
        /// </summary>
        /// <param name="conn"></param>
        public static void ClearDatabase(DatabaseConnection conn)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn.getConnection();
            cmd.CommandText = @"DELETE FROM track_segments";
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmd"></param>
        /// <param name="obj"></param>
        public static void InsertIntoDatabase(DatabaseConnection conn, TrackSegment obj)
        {

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText =
                @"Insert into track_segments (trackCircuit, direction, move, brakeLocation, targetLocation, worst_case_grade_during_stop, max_entry_speed, overSpeed, vehicleAccel, reactionTime, brakeRate, runwayAccel, propulsion, build_up_brake, overhang) VALUES (@trackCircuit, @direction, @move, @brakeLocation, @targetLocation, @worst_case_grade_during_stop, @max_entry_speed, @overSpeed, @vehicleAccel, @reactionTime, @brakeRate, @runwayAccel, @propulsion, @build_up_brake, @overhang)";
            cmd.Parameters.AddWithValue("@trackCircuit", obj.TrackCircuit);
            cmd.Parameters.AddWithValue("@direction", obj.Direction);
            cmd.Parameters.AddWithValue("@move", obj.Move);
            cmd.Parameters.AddWithValue("@brakeLocation", obj.BrakeLocation);
            cmd.Parameters.AddWithValue("@targetLocation", obj.TargetLocation);
            cmd.Parameters.AddWithValue("@worst_case_grade_during_stop", obj.GradeWorst);
            cmd.Parameters.AddWithValue("@max_entry_speed", obj.SpeedMax);
            cmd.Parameters.AddWithValue("@overSpeed", obj.OverSpeed);
            cmd.Parameters.AddWithValue("@vehicleAccel", obj.VehicleAccel);
            cmd.Parameters.AddWithValue("@reactionTime", obj.ReactionTime);
            cmd.Parameters.AddWithValue("@brakeRate", obj.BrakeRate);
            cmd.Parameters.AddWithValue("@runwayAccel", obj.RunwayAccelSec);
            cmd.Parameters.AddWithValue("@propulsion", obj.PropulsionRemSec);
            cmd.Parameters.AddWithValue("@build_up_brake", obj.BrakeBuildUpSec);
            cmd.Parameters.AddWithValue("@overhang", obj.OverhangDist);
            cmd.Connection = conn.getConnection();
            cmd.ExecuteNonQuery();

        }
       
        public static void removeFromDatabase(DatabaseConnection conn, Query q, TrackSegment obj)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText =
                @"Delete from track_segments (trackCircuit, brakeLocation, targetLocation, worst_case_grade_during_stop, max_entry_speed, overSpeed, vehicleAccel, reactionTime, brakeRate, runwayAccel, propulsion, build_up_brake, overhang) VALUES (@trackCircuit, @brakeLocation, @targetLocation, @worst_case_grade_during_stop, @max_entry_speed, @overSpeed, @vehicleAccel, @reactionTime, @brakeRate, @runwayAccel, @propulsion, @build_up_brake, @overhang)";
            cmd.Parameters.AddWithValue("@trackCircuit", obj.TrackCircuit);
            cmd.Parameters.AddWithValue("@brakeLocation", obj.StartPoint);
            cmd.Parameters.AddWithValue("@targetLocation", obj.EndPoint);
            cmd.Parameters.AddWithValue("@worst_case_grade_during_stop", obj.GradeWorst);
            cmd.Parameters.AddWithValue("@max_entry_speed", obj.SpeedMax);
            cmd.Parameters.AddWithValue("@overSpeed", obj.OverSpeed);
            cmd.Parameters.AddWithValue("@vehicleAccel", obj.VehicleAccel);
            cmd.Parameters.AddWithValue("@reactionTime", obj.ReactionTime);
            cmd.Parameters.AddWithValue("@brakeRate", obj.BrakeRate);
            cmd.Parameters.AddWithValue("@runwayAccel", obj.RunwayAccelSec);
            cmd.Parameters.AddWithValue("@propulsion", obj.PropulsionRemSec);
            cmd.Parameters.AddWithValue("@build_up_brake", obj.BrakeBuildUpSec);
            cmd.Parameters.AddWithValue("@overhang", obj.OverhangDist);
            cmd.Connection = conn.getConnection();
            cmd.ExecuteNonQuery();
        }


    }
}

