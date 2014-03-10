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
        /// <param name="_a"></param>
        /// <param name="_b"></param>
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
        public TrackSegment(Vector2 _a, Vector2 _b,
            int brakeLocation, int targetLocation, double gradeWorst,
            double speedMax, double overspeed, double vehicleAccel,
            double reactionTime, double brakeRate, double runwayAccelSec,
            double propulsionRemSec, int brakeBuildUpSec, int overhangDist,
            double safetyFact)
            : base(_a, _b)
        {
            SafeBreakingDistance = Algorithms.SafeBrakingDistanceCalculations(brakeLocation, targetLocation, gradeWorst,
                speedMax, overspeed, vehicleAccel, reactionTime, brakeRate, runwayAccelSec, propulsionRemSec,
                brakeBuildUpSec, overhangDist, safetyFact);
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



    }
}
