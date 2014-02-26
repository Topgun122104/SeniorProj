using System;

namespace RailRoadSignal.GEAlgorithms
{
    /// <summary>
    /// 
    /// </summary>
    class Algorithms
    {
        const double MPH_TO_FPS = 1.467;
        const double FPS_TO_MPH = 0.7333;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cabCommandSpeed"></param>
        /// <param name="grade"></param>
        /// <returns></returns>
        static double SafeBrakingDistanceCalc(double cabCommandSpeed, double grade)
        {
            //Vos is assumed to be cab command speed + 4mph overspeed
            double Vos = cabCommandSpeed + 4.0; // in units: MPH
            double RTmax = 3.8; // in units: seconds
            //Final velocity when braking will be zero
            double vF = 0;
            //Used to adjust braking distance for effects of grade
            double correctionFactor = 0.22;
            //De-rated brake rate
            double BReff = 1.95; //in units: MPHPS
            //35% safety factor to be applied to braking portion of calculation only
            double safetyFactor = 1.35;
            //Vehicle overhang is 7' on each end
            double overHang = 14; //in units: Feet

            //Actual safe braking distance
            double SBD = (Vos * RTmax * MPH_TO_FPS) + ((Math.Pow(Vos, 2) - Math.Pow(vF, 2))
                * (FPS_TO_MPH / (correctionFactor * grade + BReff))) * safetyFactor + overHang;

            return SBD;

        }
    }
}
