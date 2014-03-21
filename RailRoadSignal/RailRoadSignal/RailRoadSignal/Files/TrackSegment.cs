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
        /// <param name="_a">End point for the line</param>
        /// <param name="_b">End point for the line</param> 
        public TrackSegment(Vector2 _a, Vector2 _b)
            : base(_a, _b) { }
        /// <summary>
        /// Constructor for a new line
        /// </summary>
        /// <param name="_a">End point for the line</param>
        /// <param name="_b">End point for the line</param>
        /// <param name="_thickness">The thickness to draw the line</param>
        /// <param name="_depth">The sorting depth of the sprite, between 0 (front) and 1 (back).</param>
        public TrackSegment(Vector2 _a, Vector2 _b, float _thickness, float _depth)
            : base(_a, _b, _thickness, _depth) { }


        //**************************************
        /* Add additional constructors here */
        //**************************************

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startPoint"></param>
        /// <param name="endPoint"></param>
        /// <param name="brakeLocation"></param>
        /// <param name="targetLocation"></param>
        /// <param name="gradeWorst"></param>
        /// <param name="speedMax"></param>
        /// <param name="overspeed"></param>
        /// <param name="vehicleAccel"></param>
        /// <param name="reactionTime"></param>
        /// <param name="brakeRate"></param>
        /// <param name="runwayAccelSec"></param>
        /// <param name="propulsionRemSec"></param>
        /// <param name="brakeBuildUpSec"></param>
        /// <param name="overhangDist"></param>
        /// <param name="safetyFact"></param>
        public TrackSegment(Vector2 startPoint, Vector2 endPoint,
                            int brakeLocation, int targetLocation, double gradeWorst,
                             double speedMax, double overSpeed, double vehicleAccel, 
                            double reactionTime, double brakeRate, double runwayAccelSec, 
                            double propulsionRemSec, int brakeBuildUpSec, int overhangDist, double safetyFact)
                            : base(startPoint, endPoint)
        {
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

        /// <summary>
        /// 
        /// </summary>
        public double ApproachLockingTime { get; set; }


        public int BrakeLocation { get; set; }
        public int TargetLocation { get; set; }
        public int BrakeBuildUpSec { get; set; }
        public int OverhangDist { get; set; }
        public double GradeWorst { get; set; }
        public double SpeedMax { get; set; }
        public double OverSpeed { get; set; }
        public double VehicleAccel { get; set; }
        public double ReactionTime { get; set; }
        public double BrakeRate { get; set; }
        public double RunwayAccelSec { get; set; }
        public double PropulsionRemSec { get; set; }
        public double SafetyFact { get; set; }
    }
}
