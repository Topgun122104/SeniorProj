
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using OpenTK;

namespace Signal_Block_Design_Tool.Files
{
    public class Camera2D
    {
        public Vector2 _pos;
        public Vector2 _origin;
        public float _rotation;
        protected float _zoom;
        protected Transformation _transform;

        private float maxZoom = 5.0f;
        private float minZoom = 0.5f;
        protected struct Transformation
        {
            internal Matrix4 _matrix;
            Vector2 _lastPositon;
            float _lastZoom;
            Vector2 _lastOrigin;
            float _lastRotation;
            internal void Update(Vector2 position, Vector2 origin, float zoom, float rotation)
            {
                _lastPositon = position;
                _lastOrigin = origin;
                _lastZoom = zoom;
                _lastRotation = rotation;
            }
        };

        public Camera2D()
        {

        }

        public Camera2D(Vector2 position, Vector2 origin)
        {
            _pos = position;
            _origin = origin;
            _zoom = 1;
            _rotation = 0;
        }

        public void setZoom(float zoom)
        {
            _zoom = zoom;
            if (_zoom <= minZoom)
            {
                _zoom = minZoom;
            }
            if (_zoom >= maxZoom)
            {
                _zoom = maxZoom;
            }
        }

        public float getZoom()
        {
            return _zoom;
        }

        public Matrix4 getTransformation()
        {
            _transform.Update(_pos, _origin, _zoom, _rotation);

            _transform._matrix = Matrix4.CreateTranslation(-_pos.X, -_pos.Y, 0) *
                Matrix4.CreateScale(_zoom, _zoom, 1) *
                Matrix4.CreateRotationZ(_rotation) *
                Matrix4.CreateTranslation(_origin.X * .5f, _origin.Y * .5f, 0);
            return _transform._matrix;
        }
    }
}
