using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailRoadSignal.GEAlgorithms
{
    class TrackSegment
    {
        private int brakeLocation;
        private int targetLocation;
        private int brakeBuildUpSec;
        private int overhangDist;
        private double gradeWorst;
        private double speedMax;
        private double overspeed;
        private double vehicleAccel;
        private double reactionTime;
        private double brakeRate;
        private double runwayAccelSec;
        private double propulsionRemSec;
        private double safetyFact;

        public TrackSegment(int bL, int tL, double gW, double sM, double oS, double vA, double rT, double bR, 
                            double rAS, double pRS, int bBUS, int oD, double sF)
        {
            brakeLocation = bL;
            targetLocation = tL;
            gradeWorst = gW;
            speedMax = sM;
            overspeed = oS;
            vehicleAccel = vA;
            reactionTime = rT;
            brakeRate = bR;
            runwayAccelSec = rAS;
            propulsionRemSec = pRS;
            brakeBuildUpSec = bBUS;
            overhangDist = oD;
            safetyFact = sF;
        }
        
        public int getBrakelocation()
        {
            return brakeLocation;
        }

        public void setBrakelocation(int bL)
        {
            brakeLocation = bL;
        }

        public int getTargetLocation()
        {
            return targetLocation;
        }

        public void setTargetLocation(int tL)
        {
            targetLocation = tL;
        }

        public int getBrakeBuildUpSec()
        {
            return brakeBuildUpSec;
        }

        public void setBrakeBuildUpSec(int bBUS)
        {
            brakeBuildUpSec = bBUS;
        }

        public int getOverhangDist()
        {
            return overhangDist;
        }

        public void setOverhangDist(int oD)
        {
            overhangDist = oD;
        }

        public double getGradeWorst()
        {
            return gradeWorst;
        }

        public void setGradeWorst(double gW)
        {
            gradeWorst = gW;
        }

        public double getSpeedMax()
        {
            return speedMax;
        }

        public void setSpeedMax(double sM)
        {
            speedMax = sM;
        }

        public double getOverspeed()
        {
            return overspeed;
        }

        public void setOverspeed(double oS)
        {
            overspeed = oS;
        }

        public double getVehicleAccel()
        {
            return vehicleAccel;
        }

        public void setVehicleAccel(double vA)
        {
            vehicleAccel = vA;
        }

        public double getReactionTime()
        {
            return reactionTime;
        }

        public void setReactionTime(double rT)
        {
            reactionTime = rT;
        }

        public double getBrakeRate()
        {
            return brakeRate;
        }

        public void setBrakeRate(double bR)
        {
            brakeRate = bR;
        }

        public double getRunwayAccelSec()
        {
            return runwayAccelSec;
        }

        public void setRunwayAccelSec(double rAS)
        {
            runwayAccelSec = rAS;
        }

        public double getPropulsionRemSec()
        {
            return propulsionRemSec;
        }

        public void setPropulsionRemSec(double pRS)
        {
            propulsionRemSec = pRS;
        }

        public double getSafetyFact()
        {
            return safetyFact;
        }

        public void setSafetyFact(double sF)
        {
            safetyFact = sF;
        }
    }
}
