using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailRoadSignal.Files
{
    public static class TrackLayout
    {

        static List<TrackSegment> list;

        static TrackLayout()
        {
            list = new List<TrackSegment>();
        }

        static void AddTrack(TrackSegment segment)
        {
            list.Add(segment);
        }

        public static void Display()
        {
            foreach(var value in list)
            {
                Console.WriteLine(value.SafeBreakingDistance);
            }
        }
        

    }
}
