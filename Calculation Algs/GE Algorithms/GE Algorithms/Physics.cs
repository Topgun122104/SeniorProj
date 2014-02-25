using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Algorithms
{ 
    class Physics
    {
        public const double G = 6.67384e-11; //units: m^3 * kg^-1 * s^-2

        static double accelDueToGrade(double grade)
        {
            return grade * (G / (-1.4667 * 100));

        }

        static double accelGivenTime(double vF, double vI, double tF, double tI)
        {
            return (vF - vI) / (tF - tI);
        }

        static double accelGivenDistance(double vF, double vI, double distance)
        {
            double numerator = Math.Pow(vF, 2) - Math.Pow(vI, 2);
            double denominator = -2 * distance;
            return numerator / denominator;   
        }

        static double vFCalc(double vI, double accel, double time)
        {
            return vI + (accel * time);
        }

        static double distanceCalc(double vI, double time, double accel)
        {
            return (vI * time) + (.5 * accel * (Math.Pow(time, 2)));
        }

        static double timeCalc(double vF, double vI, double accel)
        {
            return (vF - vI) / accel;
        }


    }
}
