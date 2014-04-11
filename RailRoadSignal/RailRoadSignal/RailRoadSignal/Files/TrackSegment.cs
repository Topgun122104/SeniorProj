using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using GE_Algorithms;

namespace RailRoadSignal
{
    class TrackSegment : Line
    {
        /// <summary>
        /// Default constructor for a new track Segment
        /// </summary>
        public TrackSegment()
            : base() { }
        /// <summary>
        /// Constructor for a new line
        /// Sets the thickness to 5f, and deoth to 1.0f
        /// </summary>
        /// <param name="startPoint">End point for the line</param>
        /// <param name="endPoint">End point for the line</param> 
        public TrackSegment(Vector2 startPoint, Vector2 endPoint)
            : base(startPoint, endPoint)
        {
            TrackID = "Basic Line";
            SafeBreakingDistance = 0.00;
        }
        /// <summary>
        /// Constructor for a new line
        /// </summary>
        /// <param name="startPoint">End point for the line</param>
        /// <param name="endPoint">End point for the line</param>
        /// <param name="_thickness">The thickness to draw the line</param>
        /// <param name="_depth">The sorting depth of the sprite, between 0 (front) and 1 (back).</param>
        public TrackSegment(Vector2 startPoint, Vector2 endPoint, float _thickness, float _depth)
            : base(startPoint, endPoint, _thickness, _depth)
        {


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
        /// <param name="safetyFact">double</param>
        public TrackSegment(string trackID, string direction, string move, string trackCircuit, Vector2 startPoint, Vector2 endPoint,
                            int brakeLocation, int targetLocation, double gradeWorst,
                             double speedMax, double overSpeed, double vehicleAccel,
                            double reactionTime, double brakeRate, double runwayAccelSec,
                            double propulsionRemSec, int brakeBuildUpSec, int overhangDist, double safetyFact)
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
            SafetyFact = safetyFact;


            SafeBreakingDistance = Algorithms.SafeBrakingDistanceCalculations(BrakeLocation, TargetLocation, GradeWorst,
                SpeedMax, OverSpeed, VehicleAccel, ReactionTime, BrakeRate, RunwayAccelSec, PropulsionRemSec,
                BrakeBuildUpSec, OverhangDist, SafetyFact);
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
        /// <param name="safetyFact"></param>
        public TrackSegment(string trackID, string direction, string move, string trackCircuit, int startX, int startY, int endX, int endY,
                            int brakeLocation, int targetLocation, double gradeWorst,
                             double speedMax, double overSpeed, double vehicleAccel,
                            double reactionTime, double brakeRate, double runwayAccelSec,
                            double propulsionRemSec, int brakeBuildUpSec, int overhangDist, double safetyFact)
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
            SafetyFact = safetyFact;


            SafeBreakingDistance = Algorithms.SafeBrakingDistanceCalculations(BrakeLocation, TargetLocation, GradeWorst,
                SpeedMax, OverSpeed, VehicleAccel, ReactionTime, BrakeRate, RunwayAccelSec, PropulsionRemSec,
                BrakeBuildUpSec, OverhangDist, SafetyFact);
        }


        /// <summary>
        /// 
        /// </summary>
        public double SafeBreakingDistance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double Headway { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double RuntimePerformance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double ClearTime { get; set; }


        /////////////////////////////////////////////////////////////////////////////


        /// <summary>
        /// 
        /// </summary>
        public double ApproachLockingTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TrackID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Direction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Move { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TrackCircuit { get; set; }
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
        public int BrakeBuildUpSec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int OverhangDist { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double GradeWorst { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double SpeedMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double OverSpeed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double VehicleAccel { get; set; }

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
        public double RunwayAccelSec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double PropulsionRemSec { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double SafetyFact { get; set; }

    }
}
