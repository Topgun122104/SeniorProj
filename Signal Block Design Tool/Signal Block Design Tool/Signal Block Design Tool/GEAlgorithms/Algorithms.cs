using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Signal_Block_Design_Tool.GEAlgorithms
{
    public class Algorithms
    {

        /// <summary>
        /// Algorithm to calculate the safe breaking distance
        /// for a single piece of track
        /// </summary>
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
        /// <returns></returns>
        public static double SafeBrakingDistanceCalculations(int brakeLocation, int targetLocation, double gradeWorst,
                                              double speedMax, double overspeed, double vehicleAccel,
                                              double reactionTime, double brakeRate, double runwayAccelSec,
                                              double propulsionRemSec, int brakeBuildUpSec, int overhangDist,
                                              double safetyFact)
        {
            double availStopDist = Math.Abs(targetLocation - brakeLocation);
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
            bool isSafe = SBD < availStopDist;
            if (!isSafe)
            {
                 string response = "This is an unsafe condition!\n\n There are " + Math.Abs(SBD - availStopDist) + 
                      " feet lees then required for a safe breaking condition";
                 MessageBox.Show(response, "Cirtical Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return SBD;
            }
            return SBD;
        }


        public static double RuntimePerformanceCalculations()
        {
            return 0;
        }
        /// <sumary>
        /// Test main for safe breaking distance calculations
        /// </summary>
        static int Main(string[] args)
        {
             double test1 = SafeBrakingDistanceCalculations(48895, 49485, 1.296, 15.0, 1.0, 2.31, 4.8, 1.67, 1.2, 0.5, 1, 28, 0);
            Console.WriteLine(test1);
            double test2 = SafeBrakingDistanceCalculations(48895, 50100, 2.467, 35.0, 2.0, 1.6007, 4.8, 1.67, 1.2, 0.5, 1, 28, 0);
            Console.WriteLine(test2);
            double test3 = SafeBrakingDistanceCalculations(49485, 50100, 3.59, 20.0, 1.0, 2.31, 4.8, 1.67, 1.2, 0.5, 1, 28, 0);
            Console.WriteLine(test3);
            double test4 = SafeBrakingDistanceCalculations(49485, 51066, 1.879, 45.0, 2.0, 1.0565, 4.8, 1.67, 1.2, 0.5, 1, 28, 0);
            Console.WriteLine(test4);
            double test5 = SafeBrakingDistanceCalculations(49485, 52032, -0.405, 55.0, 2.0, 0.6079, 4.8, 1.67, 1.2, 0.5, 1, 28, 0);
            Console.WriteLine(test5);
            double test6 = SafeBrakingDistanceCalculations(50100, 51066, 0.7902, 25.0, 2.0, 2.2406, 4.8, 1.67, 1.2, 0.5, 1, 28, 0);
            Console.WriteLine(test6);
            double test7 = SafeBrakingDistanceCalculations(50100, 52032, -1.677, 35.0, 2.0, 1.6007, 4.8, 1.67, 1.2, 0.5, 1, 28, 0);
            Console.WriteLine(test7);
            double test8 = SafeBrakingDistanceCalculations(50100, 52998, -0.962, 55.0, 2.0, 0.6079, 4.8, 1.67, 1.2, 0.5, 1, 28, 0);
            Console.WriteLine(test8);
            double test9 = SafeBrakingDistanceCalculations(51066, 52998, -1.837, 35.0, 2.0, 1.6007, 4.8, 1.67, 1.2, 0.5, 1, 28, 0);
            Console.WriteLine(test9);
            double test10 = SafeBrakingDistanceCalculations(51066, 53964, -2.032, 45.0, 2.0, 1.0565, 4.8, 1.67, 1.2, 0.5, 1, 28, 0);
            Console.WriteLine(test10);
            double test11 = SafeBrakingDistanceCalculations(51066, 54930, -0.819, 65.0, 2.0, 0.3471, 4.8, 1.67, 1.2, 0.5, 1, 28, 0);
            Console.WriteLine(test11);
            return 0;
        }
         
    }
}


