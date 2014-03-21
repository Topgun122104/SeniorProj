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

    }
}
