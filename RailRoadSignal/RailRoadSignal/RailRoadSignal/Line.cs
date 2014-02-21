using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RailRoadSignal
{
    public class Line
    {
        // equation for a line
        // y = mx + b
        
        /// <summary>
        /// End point for the line
        /// Returns a Vector2
        /// </summary>
        public Vector2 PointA { get; set; }
        /// <summary>
        /// End point for the line
        /// Returns a Vector2
        /// </summary>
        public Vector2 PointB { get; set; }

        /// <summary>
        /// The thickness for drawing the line
        /// </summary>
        private float Thickness;

        /// <summary>
        /// The sorting depth of the sprite, between 0 (front) and 1 (back).
        /// </summary>
        private float Depth;

        /// <summary>
        /// Default constructor for a new line
        /// </summary>
        public Line()
        {
            PointA = new Vector2(0, 0);
            PointB = new Vector2(0, 0);
            Thickness = 1.0f;
            Depth = 0.0f;
        }

        /// <summary>
        /// Constructor for a new line
        /// Sets the thickness to 5f, and deoth to 0.0f
        /// </summary>
        /// <param name="_a">End point for the line</param>
        /// <param name="_b">End point for the line</param>
        public Line(Vector2 _a, Vector2 _b)
        {
            PointA = _a;
            PointB = _b;
            Thickness = 5f;
            Depth = 0.0f;
        }
        /// <summary>
        /// Constructor for a new line
        /// </summary>
        /// <param name="_a">End point for the line</param>
        /// <param name="_b">End point for the line</param>
        /// <param name="_thickness">The thickness to draw the line</param>
        /// <param name="_depth">The sorting depth of the sprite, between 0 (front) and 1 (back).</param>
        public Line(Vector2 _a, Vector2 _b, float _thickness, float _depth)
        {
            PointA = _a;
            PointB = _b;
            Thickness = _thickness;
            Depth = _depth;
        }

        /// <summary>
        /// Draw method for drawing the line to the screen 
        /// </summary>
        /// <param name="_texture">The texture to draw to the screen </param>
        /// <param name="_spriteBatch">Sprite batch to use</param>
        /// <param name="color">The color to draw the line</param>
        public void Draw(Texture2D _texture, SpriteBatch _spriteBatch, Color color)
        {
            Vector2 tangent = PointB - PointA;
            float rotation = (float)Math.Atan2(tangent.Y, tangent.X);
            Vector2 middleOrigin = new Vector2(0, _texture.Height / 2f);
            Vector2 middleScale = new Vector2(tangent.Length(), Thickness) / 2;
            _spriteBatch.Draw(_texture, PointA, null, color, rotation, middleOrigin, middleScale, SpriteEffects.None, Depth);
        }
    }
}
