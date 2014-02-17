
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RailRoadSignal.CustomControls
{
    public class View
    {
        private Matrix m_transform;
        private float m_zoom;
        private Vector2 m_position;
        private float m_minZoom;
        private float m_maxZoom;
        private int m_width;
        private int c_height;
        private float m_rotation;

        /// <summary>
        /// constructor for a new view 
        /// </summary>
        /// <param name="_width">The width of the screen</param>
        /// <param name="_height">The height of the screen</param>
        /// <param name="_position">The position to start in</param>
        /// <param name="_minZoom">The minimum amount of zoom</param>
        /// <param name="_maxZoom">The maximum amount of zoom</param>
        public View(int _width, int _height,
            Vector2 _position, float _minZoom, float _maxZoom)
        {
            m_zoom = 1.0f;
            m_rotation = 0.0f;
            m_position = _position;
            m_minZoom = _minZoom;
            m_maxZoom = _maxZoom;
            c_height = _height;
            m_width = _width;
        }
        /// <summary>
        /// Get and Set for the Zoom
        /// </summary>
        public float Zoom
        {
            get { return m_zoom; }
            set
            {
                m_zoom = value;
                if (Zoom < m_minZoom)
                {
                    m_zoom = m_minZoom;
                }
                if (Zoom > m_maxZoom)
                {
                    m_zoom = m_maxZoom;
                }
            }
        }

        public float Rotation
        {
            get { return m_rotation; }
            set { m_rotation = value; }

        }
        /// <summary>
        /// Move the view to specified point.
        /// </summary>
        /// <param name="value"> the position to move to</param>
        public void Move(Vector2 value)
        {
            Position = value;
        }
        /// <summary>
        /// Move the view up by the value
        /// </summary>
        /// <param name="value">the amount to move the view</param>
        public void MoveUp(float value)
        {
            Move(new Vector2(Position.X, Position.Y + value));
        }
        /// <summary>
        /// Move the view down by the value
        /// </summary>
        /// <param name="value">the amount to move the view</param>
        public void MoveDown(float value)
        {
            Move(new Vector2(Position.X, Position.Y - value));
        }
        /// <summary>
        /// Move the view left by the value
        /// </summary>
        /// <param name="value">the amount to move the view</param>
        public void MoveLeft(float value)
        {
            Move(new Vector2(Position.X - value, Position.Y));
        }
        /// <summary>
        /// Move the view right by the value
        /// </summary>
        /// <param name="value">the amount to move the view</param>
        public void MoveRight(float value)
        {
            Move(new Vector2(Position.X + value, Position.Y));
        }
        /// <summary>
        /// Get and private Set for the position
        /// </summary>
        public Vector2 Position
        {
            get { return m_position; }
            private set { m_position = value; }
        }
        /// <summary>
        /// Creates the transforms for the view matrix
        /// </summary>
        /// <param name="graphicsDevice">The Graphics Device</param>
        /// <returns>Matrix of the view</returns>
        public Matrix getTransformation(GraphicsDevice graphicsDevice)
        {
           m_transform = Matrix.CreateTranslation(new Vector3(-Position.X, -Position.Y, 0)) *
                Matrix.CreateRotationZ(Rotation) *
                Matrix.CreateScale(new Vector3(Zoom, Zoom, 1)) *
                Matrix.CreateTranslation(new Vector3(m_width * 0.5f, c_height * 0.5f, 0));
            return m_transform;
        }
    }
}
