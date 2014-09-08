using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Block_Design_Tool.Files
{
    static class TrackLayout
    {
        /// <summary>
        /// 
        /// </summary>
        static List<TrackSegment> list = new List<TrackSegment>();
        
        /// <summary>
        /// 
        /// </summary>
        public static List<TrackSegment> Track
        {
            get { return list; }
            set { list = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static string Customer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static string ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static string Contract { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static double PostRange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static bool Miles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static bool Kilometers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static string Preparer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static double MaxSpeed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static string TrainType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static double Tonnage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static double MaxBlockLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static string BreakingCharacteristics { get; set; }

    }
}
