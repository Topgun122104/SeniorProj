using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Block_Design_Tool.Files
{
    public class ExcelRow
    {
        /// <summary>
        /// Empty constructor
        /// </summary>
        public ExcelRow()
        {
        }
        /// <summary>
        /// Full constructor for a new excel row
        /// </summary>
        /// <param name="track"></param>
        /// <param name="direction"></param>
        /// <param name="moveNormRevDiv"></param>
        /// <param name="circuit"></param>
        /// <param name="brakeLocation"></param>
        /// <param name="targetLocation"></param>
        /// <param name="worstCaseGrade"></param>
        /// <param name="entrySpeed"></param>
        /// <param name="overSpeed"></param>
        /// <param name="acceleration"></param>
        /// <param name="reactionTime"></param>
        /// <param name="brakeRate"></param>
        /// <param name="runawayAccel"></param>
        /// <param name="propulsionRemoval"></param>
        /// <param name="brakeBuildUp"></param>
        /// <param name="overhangDist"></param>
        public ExcelRow(int track, String direction, String moveNormRevDiv, String circuit, int brakeLocation, int targetLocation, double worstCaseGrade,
            double entrySpeed, double overSpeed, double acceleration, double reactionTime, double brakeRate, double runawayAccel, double propulsionRemoval,
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

        /// <summary>
        /// used to display the track info in the console window.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// The Track ID from the Excel file
        /// </summary>
        public int TrackID { get; set; }

        /// <summary>
        /// The Direction that the track is going
        /// </summary>
        public String Direction { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String MoveNormRevDiv { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String Circuit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int BrakeLocation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int TargetLocation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double WorstCaseGrade { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double EntrySpeed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Overspeed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Acceleration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double ReactionTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double BrakeRate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double RunawayAccel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double PropulsionRemoval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int BrakeBuildUp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int OverhangDist { get; set; }
    }
}