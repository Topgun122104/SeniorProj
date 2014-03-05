using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RailRoadSignal
{
    class TrackSegment : Line
    {
        /// <summary>
        /// Default constructor for a new track Segment
        /// </summary>
        public TrackSegment()
            : base() { }
        /// <summary>
        /// Constructor for a new line
        /// Sets the thickness to 5f, and deoth to 1.0f
        /// </summary>
        /// <param name="_a">End point for the line</param>
        /// <param name="_b">End point for the line</param>
        public TrackSegment(Vector2 _a, Vector2 _b)
            : base(_a, _b) {  }
        /// <summary>
        /// Constructor for a new line
        /// </summary>
        /// <param name="_a">End point for the line</param>
        /// <param name="_b">End point for the line</param>
        /// <param name="_thickness">The thickness to draw the line</param>
        /// <param name="_depth">The sorting depth of the sprite, between 0 (front) and 1 (back).</param>
        public TrackSegment(Vector2 _a, Vector2 _b, float _thickness, float _depth)
            : base(_a, _b, _thickness, _depth) { }


        //**************************************
        /* Add additional constructors here */
        //**************************************



    }
}
