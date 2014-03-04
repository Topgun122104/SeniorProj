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
        static double SafeBrakingDistanceCalc(int brakeLocation, int targetLocation, double gradeWorst,
                                              double speedMax, double overspeed, double vehicleAccel,
                                              double reactionTime, double brakeRate, double runwayAccelSec,
                                              double propulsionRemSec, int brakeBuildUpSec, int overhangDist,
                                              double safetyFact)
        {
            int availStopDist = Math.Abs(targetLocation - brakeLocation);
            //Console.WriteLine(availStopDist);
            double overspeedTotal = overspeed + speedMax;
            //Console.WriteLine(overspeedTotal);
            double velocityFinal = (vehicleAccel * 1.2) + overspeedTotal;
            //Console.WriteLine(velocityFinal);
            double reactionDist = reactionTime * overspeedTotal * 1.467;
            //Console.WriteLine(reactionDist);
            double negGradeAdjBrakeDist = 0.733 * velocityFinal * velocityFinal / (brakeRate + (0.219 * gradeWorst));
            //Console.WriteLine(negGradeAdjBrakeDist);
            double posGradeAdjBrakeDist = 0.733 * velocityFinal * velocityFinal / (brakeRate - (0.219 * gradeWorst));
            //Console.WriteLine(posGradeAdjBrakeDist);
            double runwayAccelFt = 1.467 * (0.5 * vehicleAccel * runwayAccelSec + overspeedTotal) * runwayAccelSec;
            //Console.WriteLine(runwayAccelFt);
            double propulsionRemFt = velocityFinal * 1.467 * propulsionRemSec;
            //Console.WriteLine(propulsionRemFt);
            double brakeBuildUpFt = velocityFinal * 1.467 * brakeBuildUpSec;
            //Console.WriteLine(brakeBuildUpFt);
            double SBD = Math.Round(reactionDist + runwayAccelFt + propulsionRemFt + brakeBuildUpFt + negGradeAdjBrakeDist + overhangDist, 1);
            return SBD;
        }

        static int Main(string[] args)
        {
            double test1 = SafeBrakingDistanceCalc(48895, 49485, 1.296, 15.0, 1.0, 2.31, 4.8, 1.67, 1.2, 0.5, 1, 28, 0);
            Console.WriteLine(test1);
            double test2 = SafeBrakingDistanceCalc(48895, 50100, 2.467, 35.0, 2.0, 1.6007, 4.8, 1.67, 1.2, 0.5, 1, 28, 0);
            Console.WriteLine(test2);
            double test3 = SafeBrakingDistanceCalc(49485, 50100, 3.59, 20.0, 1.0, 2.31, 4.8, 1.67, 1.2, 0.5, 1, 28, 0);
            Console.WriteLine(test3);
            double test4 = SafeBrakingDistanceCalc(49485, 51066, 1.879, 45.0, 2.0, 1.0565, 4.8, 1.67, 1.2, 0.5, 1, 28, 0);
            Console.WriteLine(test4);
            double test5 = SafeBrakingDistanceCalc(49485, 52032, -0.405, 55.0, 2.0, 0.6079, 4.8, 1.67, 1.2, 0.5, 1, 28, 0);
            Console.WriteLine(test5);
            double test6 = SafeBrakingDistanceCalc(50100, 51066, 0.7902, 25.0, 2.0, 2.2406, 4.8, 1.67, 1.2, 0.5, 1, 28, 0);
            Console.WriteLine(test6);
            double test7 = SafeBrakingDistanceCalc(50100, 52032, -1.677, 35.0, 2.0, 1.6007, 4.8, 1.67, 1.2, 0.5, 1, 28, 0);
            Console.WriteLine(test7);
            double test8 = SafeBrakingDistanceCalc(50100, 52998, -0.962, 55.0, 2.0, 0.6079, 4.8, 1.67, 1.2, 0.5, 1, 28, 0);
            Console.WriteLine(test8);
            double test9 = SafeBrakingDistanceCalc(51066, 52998, -1.837, 35.0, 2.0, 1.6007, 4.8, 1.67, 1.2, 0.5, 1, 28, 0);
            Console.WriteLine(test9);
            double test10 = SafeBrakingDistanceCalc(51066, 53964, -2.032, 45.0, 2.0, 1.0565, 4.8, 1.67, 1.2, 0.5, 1, 28, 0);
            Console.WriteLine(test10);
            double test11 = SafeBrakingDistanceCalc(51066, 54930, -0.819, 65.0, 2.0, 0.3471, 4.8, 1.67, 1.2, 0.5, 1, 28, 0);
            Console.WriteLine(test11);
            return 0;
        }
    }
}


