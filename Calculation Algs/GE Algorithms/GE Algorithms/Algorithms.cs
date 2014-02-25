/* GE Railroad Signaling Block Design Tool Algorithms
 
 The following are specific parameters to be used in the formulas to follow:

 Safe Breaking Calculation - The distance the train travels from when the train driver
 makes a full service brake application to when the train stops.
 
 Headway Calculation - Headway is the time spacing between trains
 
 Runtime Performance Calculations - Run time is the time of travel between any two points, 
 but is normally given from the start of a run - departure from the initial station, to the end of
 a run - arrival at the final station
 
 Clear Time Calculation - The clear time of a track circuit is the time from a train entering a track circuit to
 the time the rear of the train is clear of the track circuit ahead which permits this track circuit to return
 to the maximum cab signal speed provided by the block layout
 
 Approach Locking Time Calculation - The locking of any route from a signal, when the driver has seen or may have seen
 a proceed aspect at a signal that would indicate to the driver that the former signal is displaying a proceed aspect.
 If the signal is replaced to danger, the approach locking prevents the immediate release of the route because it is
 possible that an approaching train may be unable to stop.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Algorithms
{
    class Algorithms
    {
        static const double MPH_TO_FPS = 1.467;
        static const double FPS_TO_MPH = 0.7333;

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
