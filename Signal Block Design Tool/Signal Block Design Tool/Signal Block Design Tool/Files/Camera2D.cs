using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Block_Design_Tool.Files
{
    class Camera2D
    {

        public enum DrawMode
        {
            NORMAL,
            WIREFRAME,
        }

        public float X { get; set; }
        public float Y { get; set; }
        public float Angle { get; set; }

        private DrawMode _mode;
        public DrawMode Mode
        {
            get { return _mode; }
            set
            {
                _mode = value;
                UpdateDrawMode();
            }
        }

        public Camera2D(float x = 0.0f, float y = 0.0f)
        {
            X = x;
            Y = y;
            _mode = DrawMode.NORMAL;
        }

        private void UpdateDrawMode()
        {
            switch(_mode)
            {
                case DrawMode.NORMAL:
                    OpenTK.Graphics.OpenGL.GL.PolygonMode(OpenTK.Graphics.OpenGL.MaterialFace.FrontAndBack, OpenTK.Graphics.OpenGL.PolygonMode.Fill);
                    break;
                case DrawMode.WIREFRAME:
                    OpenTK.Graphics.OpenGL.GL.PolygonMode(OpenTK.Graphics.OpenGL.MaterialFace.Front, OpenTK.Graphics.OpenGL.PolygonMode.Line);
                    break;
            }
        }

        public void Update()
        {
            OpenTK.Graphics.OpenGL.GL.Rotate(Angle, 0, 0, 1);
            OpenTK.Graphics.OpenGL.GL.Translate(-X, -Y, 0);
        }

    }
}
