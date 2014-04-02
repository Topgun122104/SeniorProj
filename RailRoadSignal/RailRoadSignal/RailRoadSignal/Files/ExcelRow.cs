using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailRoadSignal.Files
{
    public class ExcelRow
    {
         

        public ExcelRow()
        {
        }

        public ExcelRow(int track, String direction, String moveNormRevDiv, String circuit, int brakeLocation, int targetLocation, double worstCaseGrade,
            int entrySpeed, double overSpeed, double acceleration, double reactionTime, double brakeRate, double runawayAccel, double propulsionRemoval,
            int brakeBuildUp, int overhangDist)
        {
            TrackID = track;
            Direction = direction;
            MoveNormRevDiv = moveNormRevDiv;
            Circuit = circuit;
            BrakeLocation = brakeLocation;
            TargetLocation = targetLocation;
            WorstCaseGrade = worstCaseGrade;
            EntrySpeed = entrySpeed;
            Overspeed = overSpeed;
            Acceleration = acceleration;
            ReactionTime = reactionTime;
            BrakeRate = brakeRate;
            RunawayAccel = runawayAccel;
            PropulsionRemoval = propulsionRemoval;
            BrakeBuildUp = brakeBuildUp;
            OverhangDist = overhangDist;
        }

        public string displayRow()
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.Append(TrackID + " ");
            strBuild.Append(Direction + " ");
            strBuild.Append(MoveNormRevDiv + " ");
            strBuild.Append(Circuit + " ");
            strBuild.Append(BrakeLocation + " ");
            strBuild.Append(TargetLocation + " ");
            strBuild.Append(WorstCaseGrade + " ");
            strBuild.Append(EntrySpeed + " ");
            strBuild.Append(Overspeed + " ");
            strBuild.Append(Acceleration + " ");
            strBuild.Append(ReactionTime + " ");
            strBuild.Append(BrakeRate + " ");
            strBuild.Append(RunawayAccel + " ");
            strBuild.Append(PropulsionRemoval + " ");
            strBuild.Append(BrakeBuildUp + " ");
            strBuild.Append(OverhangDist + " ");
            strBuild.Append("\n");
            return strBuild.ToString();
        }

        public int TrackID { get; set; }
        public String Direction { get; set; }
        public String MoveNormRevDiv { get; set; }
        public String Circuit { get; set; }
        public int BrakeLocation { get; set; }
        public int TargetLocation { get; set; }
        public double WorstCaseGrade { get; set; }
        public int EntrySpeed { get; set; }
        public double Overspeed { get; set; }
        public double Acceleration { get; set; }
        public double ReactionTime { get; set; }
        public double BrakeRate { get; set; }
        public double RunawayAccel { get; set; }
        public double PropulsionRemoval { get; set; }
        public int BrakeBuildUp { get; set; }
        public int OverhangDist { get; set; }
    }
}