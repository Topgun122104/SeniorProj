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
        private Camera2D camera;
        OpenTK.Matrix4d matrix;
        private Stopwatch stopwatch;
        private double accumulator = 0;
        private int idleCounter = 0;

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
            OpenTK.Graphics.GraphicsContext.CurrentContext.SwapInterval = 100;
            Application.Idle += Application_Idle;
            OpenTK.Graphics.OpenGL.GL.ClearColor(Color.Black);
            SetupViewport();
        }

        void Application_Idle(object sender, EventArgs e)
        {
            double milliseconds = ComputeTimeSlice();
            Accumulate(milliseconds);
            Draw();

        }

        private void Accumulate(double milliseconds)
        {
            idleCounter++;
            accumulator += milliseconds;
            if (accumulator > 1000)
            {
                FPSLabel.Text = "FPS: " + idleCounter.ToString();
                accumulator -= 1000;
                idleCounter = 0;
            }
        }

        private double ComputeTimeSlice()
        {
            stopwatch.Stop();
            double timeslice = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Reset();
            stopwatch.Start();
            return timeslice;
        }
        private void SetupViewport()
        {
            int WIDTH = glControl1.Width;
            int HEIGHT = glControl1.Height;

            float nearDistance = 0.0f;
            float farDistance = 4.0f;
            matrix = OpenTK.Matrix4d.CreateOrthographic(WIDTH, HEIGHT, nearDistance, farDistance);
            OpenTK.Graphics.OpenGL.GL.MatrixMode(OpenTK.Graphics.OpenGL.MatrixMode.Projection);
            OpenTK.Graphics.OpenGL.GL.LoadMatrix(ref matrix);
        }

        private void glControl1_Resize(object sender, EventArgs e)
        {
            if (!loaded)
            {
                return;
            }
            SetupViewport();
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
            double milliseconds = ComputeTimeSlice();
            Accumulate(milliseconds);


        }
        private void Draw()
        {
            // clears the back buffer
            OpenTK.Graphics.OpenGL.GL.Clear(OpenTK.Graphics.OpenGL.ClearBufferMask.ColorBufferBit |
               OpenTK.Graphics.OpenGL.ClearBufferMask.DepthBufferBit);


            DrawBackgroundLines();

            foreach (TrackSegment t in TrackLayout.Track)
            {

            }

            // Swap the buffers 
            if (glControl1.Focused)
            {
                glControl1.SwapBuffers();
            }
        }

        private static void DrawBackgroundLines()
        {


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



        }

        private void glControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!loaded)
            {
                return;
            }

            if (e.KeyCode == Keys.Right)
            {
                camera.X += 10;
                camera.Angle += 2;
                camera.Update();
                SetupViewport();
            }
        }


    }
}
