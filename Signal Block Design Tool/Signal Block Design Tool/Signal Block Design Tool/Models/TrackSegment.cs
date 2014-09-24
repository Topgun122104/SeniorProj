using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using Signal_Block_Design_Tool.GEAlgorithms;
using System.Windows.Forms;
using OpenTK;

namespace Signal_Block_Design_Tool.Files
{
    public class TrackSegment : Line
    {
        /// <summary>
        /// Constructor for a new line
        /// Sets the thickness to 5f, and deoth to 1.0f
        /// </summary>
        /// <param name="startPoint">End point for the line</param>
        /// <param name="endPoint">End point for the line</param>
        public TrackSegment(Vector2 startPoint, Vector2 endPoint)
            : base(startPoint, endPoint)
        {
            //TrackID = "Basic Line";
            //SafeBreakingDistance = 0.00;
        }

        //**************************************
        /* Add additional constructors here */
        //**************************************

        /// <summary>
        /// 
        /// </summary>
        /// <param name="trackID">string</param>
        /// <param name="direction"></param>
        /// <param name="move"></param>
        /// <param name="trackCircuit"></param>
        /// <param name="startPoint">Vector2</param>
        /// <param name="endPoint">Vector2</param>
        /// <param name="brakeLocation">int</param>
        /// <param name="targetLocation">int</param>
        /// <param name="gradeWorst">double</param>
        /// <param name="speedMax">double</param>
        /// <param name="overspeed">double</param>
        /// <param name="vehicleAccel">double</param>
        /// <param name="reactionTime">double</param>
        /// <param name="brakeRate">double</param>
        /// <param name="runwayAccelSec">double</param>
        /// <param name="propulsionRemSec">double</param>
        /// <param name="brakeBuildUpSec">int</param>
        /// <param name="overhangDist">int</param>
        public TrackSegment(string trackID, string direction, string move, string trackCircuit, Vector2 startPoint, Vector2 endPoint,
                            int brakeLocation, int targetLocation, double gradeWorst,
                             double speedMax, double overSpeed, double vehicleAccel,
                            double reactionTime, double brakeRate, double runwayAccelSec,
                            double propulsionRemSec, int brakeBuildUpSec, int overhangDist)
            : base(startPoint, endPoint)
        {
            TrackID = trackID;
            Direction = direction;
            Move = move;
            TrackCircuit = trackCircuit;
            BrakeLocation = brakeLocation;
            TargetLocation = targetLocation;
            GradeWorst = gradeWorst;
            SpeedMax = speedMax;
            OverSpeed = overSpeed;
            VehicleAccel = vehicleAccel;
            ReactionTime = reactionTime;
            BrakeRate = brakeRate;
            RunwayAccelSec = runwayAccelSec;
            PropulsionRemSec = propulsionRemSec;
            BrakeBuildUpSec = brakeBuildUpSec;
            OverhangDist = overhangDist;

            SafeBreakingDistance = Algorithms.SafeBrakingDistanceCalculations(BrakeLocation, TargetLocation, GradeWorst,
                SpeedMax, OverSpeed, VehicleAccel, ReactionTime, BrakeRate, RunwayAccelSec, PropulsionRemSec,
                BrakeBuildUpSec, OverhangDist);
        }

        public TrackSegment(string trackID, string direction, string move, string trackCircuit,
                            int brakeLocation, int targetLocation, double gradeWorst,
                             double speedMax, double overSpeed, double vehicleAccel,
                            double reactionTime, double brakeRate, double runwayAccelSec,
                            double propulsionRemSec, int brakeBuildUpSec, int overhangDist)
            : base(0, 0)
        {
            TrackID = trackID;
            Direction = direction;
            Move = move;
            TrackCircuit = trackCircuit;
            BrakeLocation = brakeLocation;
            TargetLocation = targetLocation;
            GradeWorst = gradeWorst;
            SpeedMax = speedMax;
            OverSpeed = overSpeed;
            VehicleAccel = vehicleAccel;
            ReactionTime = reactionTime;
            BrakeRate = brakeRate;
            RunwayAccelSec = runwayAccelSec;
            PropulsionRemSec = propulsionRemSec;
            BrakeBuildUpSec = brakeBuildUpSec;
            OverhangDist = overhangDist;


            SafeBreakingDistance = Algorithms.SafeBrakingDistanceCalculations(BrakeLocation, TargetLocation, GradeWorst,
                SpeedMax, OverSpeed, VehicleAccel, ReactionTime, BrakeRate, RunwayAccelSec, PropulsionRemSec,
                BrakeBuildUpSec, OverhangDist);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="trackID"></param>
        /// <param name="direction"></param>
        /// <param name="move"></param>
        /// <param name="trackCircuit"></param>
        /// <param name="startX"></param>
        /// <param name="startY"></param>
        /// <param name="endX"></param>
        /// <param name="endY"></param>
        /// <param name="brakeLocation"></param>
        /// <param name="targetLocation"></param>
        /// <param name="gradeWorst"></param>
        /// <param name="speedMax"></param>
        /// <param name="overSpeed"></param>
        /// <param name="vehicleAccel"></param>
        /// <param name="reactionTime"></param>
        /// <param name="brakeRate"></param>
        /// <param name="runwayAccelSec"></param>
        /// <param name="propulsionRemSec"></param>
        /// <param name="brakeBuildUpSec"></param>
        /// <param name="overhangDist"></param>
        public TrackSegment(string trackID, string direction, string move, string trackCircuit, int startX, int startY, int endX, int endY,
                            int brakeLocation, int targetLocation, double gradeWorst,
                             double speedMax, double overSpeed, double vehicleAccel,
                            double reactionTime, double brakeRate, double runwayAccelSec,
                            double propulsionRemSec, int brakeBuildUpSec, int overhangDist)
            : base(new Vector2((float)startX, (float)startY), new Vector2((float)endX, (float)endY))
        {
            TrackID = trackID;
            Direction = direction;
            Move = move;
            TrackCircuit = trackCircuit;
            BrakeLocation = brakeLocation;
            TargetLocation = targetLocation;
            GradeWorst = gradeWorst;
            SpeedMax = speedMax;
            OverSpeed = overSpeed;
            VehicleAccel = vehicleAccel;
            ReactionTime = reactionTime;
            BrakeRate = brakeRate;
            RunwayAccelSec = runwayAccelSec;
            PropulsionRemSec = propulsionRemSec;
            BrakeBuildUpSec = brakeBuildUpSec;
            OverhangDist = overhangDist;

            SafeBreakingDistance = Algorithms.SafeBrakingDistanceCalculations(BrakeLocation, TargetLocation, GradeWorst,
                SpeedMax, OverSpeed, VehicleAccel, ReactionTime, BrakeRate, RunwayAccelSec, PropulsionRemSec,
                BrakeBuildUpSec, OverhangDist);
        }



        private double safeBreakingDistance;
        /// <summary>
        /// 
        /// </summary>
        public double SafeBreakingDistance
        {
            get { return safeBreakingDistance; }
            set { safeBreakingDistance = value; }
        }

        private double runtimePerformance;
        /// <summary>
        /// 
        /// </summary>
        public double RuntimePerformance
        {
            get { return runtimePerformance; }
            set { runtimePerformance = value; }
        }



        /////////////////////////////////////////////////////////////////////////////


        private string trackID;
        /// <summary>
        /// 
        /// </summary>
        public string TrackID
        {
            get { return trackID; }
            set { trackID = value; }
        }

        private string direction;
        /// <summary>
        /// 
        /// </summary>
        public string Direction
        {
            get { return direction; }
            set { direction = value; }
        }


        private string move;
        /// <summary>
        /// 
        /// </summary>
        public string Move
        {
            get { return move; }
            set { move = value; }
        }


        private string trackCircuit;
        /// <summary>
        /// 
        /// </summary>
        public string TrackCircuit
        {
            get { return trackCircuit; }
            set { trackCircuit = value; }
        }

        public int brakeLocation;
        /// <summary>
        /// 
        /// </summary>
        public int BrakeLocation
        {
            get { return brakeLocation; }
            set { brakeLocation = value; }
        }

        private int targetLocation;
        /// <summary>
        /// 
        /// </summary>
        public int TargetLocation
        {
            get { return targetLocation; }
            set { targetLocation = value; }
        }

        private int brakeBuildUpSec;
        /// <summary>
        /// 
        /// </summary>
        public int BrakeBuildUpSec
        {
            get { return brakeBuildUpSec; }
            set { brakeBuildUpSec = value; }
        }

        private int overhangDist;
        /// <summary>
        /// 
        /// </summary>
        public int OverhangDist
        {
            get { return overhangDist; }
            set { overhangDist = value; }
        }

        private double gradeWorst;
        /// <summary>
        /// 
        /// </summary>
        public double GradeWorst
        {
            get { return gradeWorst; }
            set { gradeWorst = value; }
        }

        private double speedMax;
        /// <summary>
        /// 
        /// </summary>
        public double SpeedMax
        {
            get { return speedMax; }
            set { speedMax = value; }
        }

        private double overSpeed;
        /// <summary>
        /// 
        /// </summary>
        public double OverSpeed
        {
            get { return overSpeed; }
            set { overSpeed = value; }
        }

        private double vehicleAccel;
        /// <summary>
        /// 
        /// </summary>
        public double VehicleAccel
        {
            get { return vehicleAccel; }
            set { vehicleAccel = value; }
        }

        private double reactionTime;
        /// <summary>
        /// 
        /// </summary>
        public double ReactionTime
        {
            get { return reactionTime; }
            set { reactionTime = value; }
        }

        private double brakeRate;
        /// <summary>
        /// 
        /// </summary>
        public double BrakeRate
        {
            get { return brakeRate; }
            set { brakeRate = value; }
        }

        private double runawayAccelSec;
        /// <summary>
        /// 
        /// </summary>
        public double RunwayAccelSec
        {
            get { return runawayAccelSec; }
            set { runawayAccelSec = value; }
        }

        private double propulsionRemSec;
        private int p1;
        private string p2;
        private string p3;
        private string p4;
        private int p5;
        private int p6;
        private double p7;
        private double p8;
        private double p9;
        private double p10;
        private double p11;
        private double p12;
        private double p13;
        private double p14;
        private int p15;
        private int p16;
        /// <summary>
        /// 
        /// </summary>
        public double PropulsionRemSec
        {
            get { return propulsionRemSec; }
            set { propulsionRemSec = value; }
        }
    }
}
