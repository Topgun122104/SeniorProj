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
        private void insertIntoDb(TrackSegment obj)
        {
            MySqlCommand cmd = new MySqlCommand();
            DatabaseConnection conn = new DatabaseConnection("andrew.cs.fit.edu", 3306, "signalblockdesign", "signalblockdesig", "E2SnzbV922m6R51");
            conn.openConnection();
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
            conn.closeConnection();


        }
    }
}
