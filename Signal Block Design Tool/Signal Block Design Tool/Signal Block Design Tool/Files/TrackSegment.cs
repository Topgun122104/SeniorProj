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
        /// Default constructor for a new track Segment
        /// </summary>
        public TrackSegment()
            : base() 
        {
            safeBreakingDistance = new List<double>();
            headway = new List<double>();
            runtimePerformance = new List<double>();
            clearTime = new List<double>();
            approachLockingTime = new List<double>();
            trackID = new List<string>();
            direction = new List<string>();
            move = new List<string>();
            trackCircuit = new List<string>();
            brakeLocation = new List<int>();
            targetLocation = new List<int>();
            brakeBuildUpSec = new List<int>();
            overhangDist = new List<int>();
            gradeWorst = new List<double>();
            speedMax = new List<double>();
            overSpeed = new List<double>();
            vehicleAccel = new List<double>();
            reactionTime = new List<double>();
            brakeRate = new List<double>();
            runawayAccelSec = new List<double>();
            propulsionRemSec = new List<double>();
            safetyFact = new List<double>();
        }
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
        /// <param name="safetyFact">double</param>
        /*public TrackSegment(string trackID, string direction, string move, string trackCircuit, Vector2 startPoint, Vector2 endPoint,
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

        public TrackSegment(string trackID, string direction, string move, string trackCircuit, int startPoint, int endPoint,
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

         */
        public double SafeBreakingDistanceSum
        {
            get
            {
                double sum = 0;
                foreach (double d in SafeBreakingDistance)
                {
                    sum += d;
                }
                return sum;
            }
        }


        private List<double> safeBreakingDistance;
        /// <summary>
        /// 
        /// </summary>
        public List<double> SafeBreakingDistance
        {
            get { return safeBreakingDistance; }
            set { safeBreakingDistance = value; }
        }

        private List<double> headway;
        /// <summary>
        /// 
        /// </summary>
        public List<double> Headway 
        {
            get { return headway; }
            set { headway = value; }
        }

        private List<double> runtimePerformance;
        /// <summary>
        /// 
        /// </summary>
        public List<double> RuntimePerformance
        {
            get { return runtimePerformance; }
            set { runtimePerformance = value; }
        }

        private List<double> clearTime;
        /// <summary>
        /// 
        /// </summary>
        public List<double> ClearTime
        {
            get { return clearTime; }
            set { clearTime = value; }
        }
        


        /////////////////////////////////////////////////////////////////////////////


        private List<double> approachLockingTime;
        /// <summary>
        /// 
        /// </summary>
        public List<double> ApproachLockingTime
        {
            get { return approachLockingTime; }
            set { approachLockingTime = value; }
        }

        private List<string> trackID;
        /// <summary>
        /// 
        /// </summary>
        public List<string> TrackID
        {
            get { return trackID; }
            set { trackID = value; }
        }

        private List<string> direction;
        /// <summary>
        /// 
        /// </summary>
        public List<string> Direction
        {
            get { return direction; }
            set { direction = value; }
        }


        private List<string> move;
        /// <summary>
        /// 
        /// </summary>
        public List<string> Move
        {
            get { return move; }
            set { move = value; }
        }


        private List<string> trackCircuit;
        /// <summary>
        /// 
        /// </summary>
        public List<string> TrackCircuit
        {
            get { return trackCircuit; }
            set { trackCircuit = value; }
        }

        public List<int> brakeLocation;
        /// <summary>
        /// 
        /// </summary>
        public List<int> BrakeLocation
        {
            get { return brakeLocation; }
            set { brakeLocation = value; }
        }

        private List<int> targetLocation;
        /// <summary>
        /// 
        /// </summary>
        public List<int> TargetLocation
        {
            get { return targetLocation; }
            set { targetLocation = value; }
        }

        private List<int> brakeBuildUpSec;
        /// <summary>
        /// 
        /// </summary>
        public List<int> BrakeBuildUpSec
        {
            get { return brakeBuildUpSec; }
            set { brakeBuildUpSec = value; }
        }

        private List<int> overhangDist;
        /// <summary>
        /// 
        /// </summary>
        public List<int> OverhangDist
        {
            get { return overhangDist; }
            set { overhangDist = value; }
        }

        private List<double> gradeWorst;
        /// <summary>
        /// 
        /// </summary>
        public List<double> GradeWorst
        {
            get { return gradeWorst; }
            set { gradeWorst = value; }
        }

        private List<double> speedMax;
        /// <summary>
        /// 
        /// </summary>
        public List<double> SpeedMax
        {
            get { return speedMax; }
            set { speedMax = value; }
        }

        private List<double> overSpeed;
        /// <summary>
        /// 
        /// </summary>
        public List<double> OverSpeed
        {
            get { return overSpeed; }
            set { overSpeed = value; }
        }

        private List<double> vehicleAccel;
        /// <summary>
        /// 
        /// </summary>
        public List<double> VehicleAccel
        {
            get { return vehicleAccel; }
            set { vehicleAccel = value; }
        }

        private List<double> reactionTime;
        /// <summary>
        /// 
        /// </summary>
        public List<double> ReactionTime
        {
            get { return reactionTime; }
            set { reactionTime = value; }
        }

        private List<double> brakeRate;
        /// <summary>
        /// 
        /// </summary>
        public List<double> BrakeRate
        {
            get { return brakeRate; }
            set { brakeRate = value; }
        }

        private List<double> runawayAccelSec;
        /// <summary>
        /// 
        /// </summary>
        public List<double> RunwayAccelSec
        {
            get { return runawayAccelSec; }
            set { runawayAccelSec = value; }
        }

        private List<double> propulsionRemSec;
        /// <summary>
        /// 
        /// </summary>
        public List<double> PropulsionRemSec
        {
            get { return propulsionRemSec; }
            set { propulsionRemSec = value; }
        }

        private List<double> safetyFact;
        /// <summary>
        /// 
        /// </summary>
        public List<double> SafetyFact
        {
            get { return safetyFact; }
            set { safetyFact = value; }
        }

    }
}
