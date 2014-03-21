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
        public Vector2 StartPoint { get; set; }
        /// <summary>
        /// End point for the line
        /// Returns a Vector2
        /// </summary>
        public Vector2 EndPoint { get; set; }

        /// <summary>
        /// The thickness for drawing the line
        /// </summary>
        protected float m_thickness;

        /// <summary>
        /// The sorting depth of the sprite, between 0 (front) and 1 (back).
        /// </summary>
        protected float m_depth;

        /// <summary>
        /// Default constructor for a new line
        /// </summary>
        public Line()
        {
            StartPoint = new Vector2(0, 0);
            EndPoint = new Vector2(0, 0);
            m_thickness = 1.0f;
            m_depth = 0.0f;
        }

        /// <summary>
        /// Constructor for a new line
        /// Sets the thickness to 5f, and deoth to 0.0f
        /// </summary>
        /// <param name="startPoint">End point for the line</param>
        /// <param name="endPoint">End point for the line</param>
        public Line(Vector2 startPoint, Vector2 endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            m_thickness = 2.0f;
            m_depth = 1.0f;
        }
        /// <summary>
        /// Constructor for a new line
        /// </summary>
        /// <param name="startPoint">End point for the line</param>
        /// <param name="endPoint">End point for the line</param>
        /// <param name="_thickness">The thickness to draw the line</param>
        /// <param name="_depth">The sorting depth of the sprite, between 0 (front) and 1 (back).</param>
        public Line(Vector2 startPoint, Vector2 endPoint, float _thickness, float _depth)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            m_thickness = _thickness;
            m_depth = _depth;
        }

        /// <summary>
        /// Draw method for drawing the line to the screen 
        /// </summary>
        /// <param name="_texture">The texture to draw to the screen </param>
        /// <param name="_spriteBatch">Sprite batch to use</param>
        /// <param name="color">The color to draw the line</param>
        public void Draw(Texture2D _texture, Texture2D _tex, SpriteBatch _spriteBatch, Color color)
        {
            Vector2 tangent = EndPoint - StartPoint;
            float rotation = (float)Math.Atan2(tangent.Y, tangent.X);
            Vector2 endOrigin = new Vector2(_texture.Width / 2, _texture.Height / 2f);
            Vector2 middleOrigin = new Vector2(0, _texture.Height / 2f);
            Vector2 middleScale = new Vector2(tangent.Length(), m_thickness) / 2;
            Vector2 midpoint = new Vector2((StartPoint.X + EndPoint.X) / 2, ((StartPoint.Y + EndPoint.Y) / 2));

            _spriteBatch.Draw(_texture, StartPoint, null, color, rotation, middleOrigin, middleScale, SpriteEffects.None, m_depth);
            _spriteBatch.Draw(_tex, midpoint, null, color, rotation, middleOrigin, 1.0f, SpriteEffects.None, m_depth);
            _spriteBatch.Draw(_texture, StartPoint, null, Color.Blue, rotation, endOrigin, m_thickness, SpriteEffects.None, m_depth - .5f);
            _spriteBatch.Draw(_texture, EndPoint, null, Color.Blue, rotation, endOrigin, m_thickness, SpriteEffects.None, m_depth - .5f);
        }
    }
}
