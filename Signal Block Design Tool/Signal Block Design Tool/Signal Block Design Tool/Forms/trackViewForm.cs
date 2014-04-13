using System;
using System.Drawing;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;
using OpenTK.Math;
using Signal_Block_Design_Tool.Files;
using System.Diagnostics;


namespace Signal_Block_Design_Tool.Forms
{
    public partial class TrackViewForm : Form
    {
        bool loaded = false;
        Camera2D camera;
        OpenTK.Matrix4d matrix;
        Stopwatch stopwatch;
        public TrackViewForm()
        {
            InitializeComponent();
            camera = new Camera2D();
            stopwatch = new Stopwatch();
            stopwatch.Start();
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            loaded = true;
            OpenTK.Graphics.GraphicsContext.CurrentContext.SwapInterval = 60;
            OpenTK.Graphics.OpenGL.GL.ClearColor(Color.Black);
            SetupViewport();
        }

        private void SetupViewport()
        {
            int WIDTH = glControl1.Width;
            int HEIGHT = glControl1.Height;
            matrix = OpenTK.Matrix4d.CreateOrthographic(WIDTH, Height, 0, 4);
            OpenTK.Graphics.OpenGL.GL.MatrixMode(OpenTK.Graphics.OpenGL.MatrixMode.Projection);
            OpenTK.Graphics.OpenGL.GL.LoadMatrix(ref matrix);
        }

        private void glControl1_Resize(object sender, EventArgs e)
        {
            if (!loaded)
            {
                return;
            }
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (!loaded)
            {
                return;
            }
            Update(stopwatch);
            Draw();
        }


        private void Update(Stopwatch stopwatch)
        {


        }
        private void Draw()
        {
            // clears the back buffer
            OpenTK.Graphics.OpenGL.GL.Clear(OpenTK.Graphics.OpenGL.ClearBufferMask.ColorBufferBit |
                OpenTK.Graphics.OpenGL.ClearBufferMask.DepthBufferBit);

            OpenTK.Graphics.OpenGL.GL.Begin(PrimitiveType.Lines);
            OpenTK.Graphics.OpenGL.GL.Vertex2(0, 0);
            OpenTK.Graphics.OpenGL.GL.Vertex2(0, 1000);

            OpenTK.Graphics.OpenGL.GL.Vertex2(0, 0);
            OpenTK.Graphics.OpenGL.GL.Vertex2(0, -1000);

            OpenTK.Graphics.OpenGL.GL.Vertex2(0, 0);
            OpenTK.Graphics.OpenGL.GL.Vertex2(1000, 0);

            OpenTK.Graphics.OpenGL.GL.Vertex2(0, 0);
            OpenTK.Graphics.OpenGL.GL.Vertex2(-1000, 0);



            OpenTK.Graphics.OpenGL.GL.End();




            // Swap the buffers 
            glControl1.SwapBuffers();

        }

        private void glControl1_KeyDown(object sender, KeyEventArgs e)
        {

        }


    }
}
