using System;

namespace Signal_Block_Design_Tool.GEAlgorithms
{
    public class Physics
    {
        /// <summary>
        /// 
        /// </summary>
        public const double G = 6.67384e-11; //units: m^3 * kg^-1 * s^-2

        /// <summary>
        /// 
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        public static double accelDueToGrade(double grade)
        {
            return grade * (G / (-1.4667 * 100));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vF"></param>
        /// <param name="vI"></param>
        /// <param name="tF"></param>
        /// <param name="tI"></param>
        /// <returns></returns>
        public static double accelGivenTime(double vF, double vI, double tF, double tI)
        {
            return (vF - vI) / (tF - tI);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vF"></param>
        /// <param name="vI"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        public static double accelGivenDistance(double vF, double vI, double distance)
        {
            double numerator = Math.Pow(vF, 2) - Math.Pow(vI, 2);
            double denominator = -2 * distance;
            return numerator / denominator;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vI"></param>
        /// <param name="accel"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static double vFCalc(double vI, double accel, double time)
        {
            return vI + (accel * time);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vI"></param>
        /// <param name="time"></param>
        /// <param name="accel"></param>
        /// <returns></returns>
        public static double distanceCalc(double vI, double time, double accel)
        {
            return (vI * time) + (.5 * accel * (Math.Pow(time, 2)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vF"></param>
        /// <param name="vI"></param>
        /// <param name="accel"></param>
        /// <returns></returns>
        public static double timeCalc(double vF, double vI, double accel)
        {
            return (vF - vI) / accel;
        }


    }
}