using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailRoadSignal.Files
{
    static class TrackLayout
    {
        static List<TrackSegment> list = new List<TrackSegment>();
        public static List<TrackSegment> Track
        {
            get { return list; }
            set { list = value; }
        }

        public static string Customer { get; set; }

        public static string ProjectName { get; set; }

        public static string Contract { get; set; }

        public static double PostRange { get; set; }

        public static bool Miles { get; set; }

        public static bool Kilometers { get; set; }

        public static string Preparer { get; set; }

        public static double MaxSpeed { get; set; }

        public static string TrainType { get; set; }

        public static double Tonnage { get; set; }

        public static double MaxBlockLength { get; set; }

        public static string BreakingCharacteristics { get; set; }







    }
}
