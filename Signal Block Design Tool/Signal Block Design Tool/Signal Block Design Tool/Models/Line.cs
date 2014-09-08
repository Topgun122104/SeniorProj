using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using OpenTK;

namespace Signal_Block_Design_Tool.Files
{
    public class Line
    {

        // equation for a line
        // y = mx + b

        private Vector2 startPoint;
        /// <summary>
        /// End point for the line
        /// Returns a Vector2
        /// </summary>
        public Vector2 StartPoint
        {
            get
            {
                return new Vector2(startPoint.X, startPoint.Y);
            }
            set
            {
                startPoint = value;
            }

        }
        /// <summary>
        /// End point for the line
        /// Returns a Vector2
        /// </summary>
        public Vector2 EndPoint { get; set; }

        public Color4 EndColor { get; set; }

        public Color4 StartColor { get; set; }
        /// <summary>
        /// The thickness for drawing the line
        /// </summary>
        protected float m_thickness;

        public bool Highlighted { get; set; }

        /// <summary>
        /// The sorting depth of the sprite, between 0 (front) and 1 (back).
        /// </summary>
        protected float m_depth;


        private Box2 BoundingRectangle(Vector2 point)
        {
            return new Box2((int)point.X - 2, (int)point.Y - 2, 4, 4);
        }
        /// <summary>
        /// Default constructor for a new line
        /// </summary>
        public Line()
        {
            StartPoint = new Vector2(0, 0);
            EndPoint = new Vector2(0, 0);
            m_thickness = 1.0f;
            m_depth = 0.0f;
            Highlighted = false;
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
            Highlighted = false;
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
            Highlighted = false;
        }

        public Line(int startPoint, int endPoint)
        {
            // TODO: Complete member initialization
            StartPoint = new Vector2(startPoint, 0);
            EndPoint = new Vector2(endPoint, 0);
        }

        /*
        /// <summary>
        /// Checks collision with the start point of the line
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool CollidesEnd(Vector2 position)
        {
            return BoundingRectangle(EndPoint).Intersects(new Box2((int)position.X, (int)position.Y, 1, 1));
        }

        /// <summary>
        /// Checks the collision with the end point of the line
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool CollidesStart(Vector2 position)
        {
            return BoundingRectangle(StartPoint).Intersects(new Box2((int)position.X, (int)position.Y, 1, 1));
        }
        /// <summary>
        /// Draw method for drawing the line to the screen 
        /// </summary>
        /// <param name="_texture">The texture to draw to the screen </param>
        /// <param name="_spriteBatch">Sprite batch to use</param>
        /// <param name="color">The color to draw the line</param>
        public void Draw(Texture2D _texture, Texture2D _tex, SpriteBatch _spriteBatch, Color color, SpriteFont font, Vector2 position)
        {
            Vector2 tangent = EndPoint - StartPoint;
            float rotation = (float)Math.Atan2(tangent.Y, tangent.X);
            Vector2 endOrigin = new Vector2(_texture.Width / 2, _texture.Height / 2f);
            Vector2 middleOrigin = new Vector2(0, _texture.Height / 2f);
            Vector2 middleScale = new Vector2(tangent.Length(), m_thickness) / 2;
            Vector2 midpoint = new Vector2((StartPoint.X + EndPoint.X) / 2, ((StartPoint.Y + EndPoint.Y) / 2));

            _spriteBatch.Draw(_texture, StartPoint, null, color, rotation, middleOrigin, middleScale, SpriteEffects.None, m_depth);
            _spriteBatch.Draw(_tex, midpoint, null, color, rotation, middleOrigin, 1.0f, SpriteEffects.None, m_depth);
            _spriteBatch.Draw(_texture, StartPoint, null, StartColor, rotation, endOrigin, m_thickness, SpriteEffects.None, m_depth - .5f);
            _spriteBatch.Draw(_texture, EndPoint, null, EndColor, rotation, endOrigin, m_thickness, SpriteEffects.None, m_depth - .5f);


        }

         */


    }
}

