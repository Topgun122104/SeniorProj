using OpenTK;
using OpenTK.Graphics.OpenGL;
using Signal_Block_Design_Tool.Files;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Signal_Block_Design_Tool.Forms
{

    #region INITIALIZE
    public partial class TrackViewForm : Form
    {
        bool loaded = false;
        private Camera2D camera;
        private bool moveCamera;
        private Stopwatch stopwatch;
        private double accumulator = 0;
        private int idleCounter = 0;
        private float rotation = 0;
        private int WIDTH;
        private int HEIGHT;
        private Vector2 currentMousePosition;
        private Vector2 previousMousePosition;
        private int currentClicks;
        private int previousClicks;
        private Font displayFont;
        private const int TRACKOFFSET = 25;
        private const int ENDTRACKSIZE = 3;
        // private Text.TextWriter writer;


        public TrackViewForm()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            stopwatch.Start();
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            loaded = true;
            displayFont = new Font(FontFamily.GenericSansSerif, 10.0f);
            OpenTK.Graphics.GraphicsContext.CurrentContext.SwapInterval = 1000;
            Application.Idle += Application_Idle;
            OpenTK.Graphics.OpenGL.GL.ClearColor(Color.Black);

            SetupViewport();
            if (TrackLayout.Track.Count > 0)
            {
                camera = new Camera2D(new OpenTK.Vector2(TrackLayout.Track[0].BrakeLocation, 0), new OpenTK.Vector2(WIDTH, HEIGHT));
            }
            else
            {
                camera = new Camera2D(new OpenTK.Vector2(0, 0), new OpenTK.Vector2(WIDTH, HEIGHT));
            }


            //writer = new Signal_Block_Design_Tool.Text.TextWriter(new Rectangle(0, 0, WIDTH, HEIGHT).Size, new Rectangle(0, 0, WIDTH, HEIGHT).Size);

            //writer.AddLine("FPS " + idleCounter.ToString(), new PointF(10, 10), Brushes.Red);

            //for (int i = 0; i < TrackLayout.Track.Count; i++)
            //{
            //    writer.AddLine(TrackLayout.Track[i].TrackCircuit.ToString(), new PointF(TrackLayout.Track[i].brakeLocation, i * 15), Brushes.Red);
            //}

        }

        private void Animate(double milliseconds)
        {
            float delta = (float)milliseconds / 20.0f;
            rotation += delta;
            glControl1.Invalidate();
        }

        void Application_Idle(object sender, EventArgs e)
        {
            double milliseconds = ComputeTimeSlice();
            Accumulate(milliseconds);
            Animate(milliseconds);
            Draw();
        }

        private void Accumulate(double milliseconds)
        {
            idleCounter++;
            accumulator += milliseconds;
            if (accumulator > 1000)
            {
                // Update the frames per second display

                //writer.Update(0, "FPS: " + idleCounter.ToString());
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
            WIDTH = glControl1.Width;
            HEIGHT = glControl1.Height;
        }

        private void glControl1_Resize(object sender, EventArgs e)
        {
            if (!loaded)
            {
                return;
            }

        }
    #endregion

        #region MAIN_LOOP
        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if (!loaded)
            {
                return;
            }
            Update(stopwatch);
            Draw();
        }
        #endregion

        #region UPDATE

        private void Update(Stopwatch stopwatch)
        {
            double milliseconds = ComputeTimeSlice();
            Accumulate(milliseconds);

            // writer.UpdateText();
        }
        #endregion

        #region DRAW
        public void Draw()
        {
            GL.MatrixMode(MatrixMode.Projection);
            GL.PushMatrix();
            GL.LoadIdentity();
            GL.Ortho(0, WIDTH, HEIGHT, 0, 0, 4.0);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.Enable(EnableCap.Texture2D);
            GL.PushMatrix();
            GL.LoadIdentity();

            GL.Viewport(0, 0, WIDTH, HEIGHT);
            OpenTK.Graphics.OpenGL.GL.Clear(OpenTK.Graphics.OpenGL.ClearBufferMask.ColorBufferBit |
              OpenTK.Graphics.OpenGL.ClearBufferMask.DepthBufferBit);

            OpenTK.Matrix4 mat = camera.getTransformation();
            GL.MultMatrix(ref mat);

            //DrawBackgroundLines();

            int t = 0;
            foreach (TrackSegment segment in TrackLayout.Track)
            {
                DrawTrackSegment(segment, t);
                t++;
            }

            OpenTK.Graphics.OpenGL.GL.End();

            //writer.Draw(camera);


            // Swap the buffers 
            if (glControl1.Focused)
            {
                glControl1.SwapBuffers();
            }
        }


        #endregion

        #region DRAW_HELPERS


        /// <summary>
        /// Draws the track segment to the screen
        /// </summary>
        /// <param name="segment">The track segment to draw</param>
        /// <param name="i">The Y off set for the track segment</param>
        private void DrawTrackSegment(TrackSegment segment, int i)
        {
            if (!segment.IsSafe)
            {
                GL.Color3(Color.Red);
            }
            else
            {
                GL.Color3(Color.Blue);
            }
            DrawLine(segment.BrakeLocation, i * TRACKOFFSET, segment.TargetLocation, i * TRACKOFFSET);
            DrawLine(segment.BrakeLocation, i * TRACKOFFSET + ENDTRACKSIZE, segment.BrakeLocation, i * TRACKOFFSET - ENDTRACKSIZE);
            DrawLine(segment.TargetLocation, i * TRACKOFFSET + ENDTRACKSIZE, segment.TargetLocation, i * TRACKOFFSET - ENDTRACKSIZE);

        }

        /// <summary>
        /// Draws a basic line to the screen
        /// </summary>
        /// <param name="startX"></param>
        /// <param name="startY"></param>
        /// <param name="stopX"></param>
        /// <param name="stopY"></param>
        private void DrawLine(int startX, int startY, int stopX, int stopY)
        {
            GL.LineWidth(2.5f);
            GL.Enable(EnableCap.LineSmooth);
            OpenTK.Graphics.OpenGL.GL.Begin(PrimitiveType.Lines);
            OpenTK.Graphics.OpenGL.GL.Vertex2(startX, startY);
            OpenTK.Graphics.OpenGL.GL.Vertex2(stopX, stopY);
            OpenTK.Graphics.OpenGL.GL.End();
        }
        private void DrawBackgroundLines()
        {
            GL.Color3(Color.Gray);
            GL.LineWidth(1f);
            GL.Enable(EnableCap.LineSmooth);
            OpenTK.Graphics.OpenGL.GL.Begin(PrimitiveType.Lines);
            OpenTK.Graphics.OpenGL.GL.Vertex2(0, -100000);
            OpenTK.Graphics.OpenGL.GL.Vertex2(0, 100000);
            OpenTK.Graphics.OpenGL.GL.Vertex2(100000, 0);
            OpenTK.Graphics.OpenGL.GL.Vertex2(-100000, 0);
            OpenTK.Graphics.OpenGL.GL.End();
        }

        #endregion
        #region INPUT
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void glControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!loaded)
            {
                return;
            }
            if (e.KeyCode == Keys.A)
            {
                camera._pos.X -= 10;
            }
            else if (e.KeyCode == Keys.D)
            {
                camera._pos.X += 10;
            }
            else if (e.KeyCode == Keys.W)
            {
                camera._pos.Y -= 10;
            }
            else if (e.KeyCode == Keys.S)
            {
                camera._pos.Y += 10;
            }
            // not sure if this is the best way.
            // seems glitchy :/
            switch (e.KeyCode)
            {
                case Keys.Add:
                    camera.setZoom(camera.getZoom() + .1f);
                    break;
                case Keys.Subtract:
                    camera.setZoom(camera.getZoom() - .1f);
                    break;
            }

        }

        private void glControl1_MouseWheel(object sender, MouseEventArgs e)
        {
            currentClicks = e.Delta;
            if (currentClicks > previousClicks)
            {
                camera.setZoom(camera.getZoom() + .1f);
                currentClicks = 0;
            }
            if (currentClicks < previousClicks)
            {
                camera.setZoom(camera.getZoom() - .1f);
                currentClicks = 0;
            }
            previousClicks = currentClicks;
        }
        private void glControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                moveCamera = true;
            }
        }

        private void glControl1_MouseUp(object sender, MouseEventArgs e)
        {
            moveCamera = false;
        }

        private void glControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (glControl1.Focused)
            {
                currentMousePosition = new Vector2(e.X, e.Y);

                if (moveCamera)
                {
                    if (currentMousePosition.X > previousMousePosition.X)
                    {
                        camera._pos.X -= (currentMousePosition.X - previousMousePosition.X) / camera.getZoom();
                    }
                    if (currentMousePosition.X < previousMousePosition.X)
                    {
                        camera._pos.X += (previousMousePosition.X - currentMousePosition.X) / camera.getZoom();
                    }
                    if (currentMousePosition.Y > previousMousePosition.Y)
                    {
                        camera._pos.Y -= (currentMousePosition.Y - previousMousePosition.Y) / camera.getZoom();
                    }
                    if (currentMousePosition.Y < previousMousePosition.Y)
                    {
                        camera._pos.Y += (previousMousePosition.Y - currentMousePosition.Y) / camera.getZoom();
                    }
                }
                previousMousePosition = currentMousePosition;
            }
        }
        #endregion

        private void GoToTrackButton_Click(object sender, EventArgs e)
        {
            int min = GetMinimum();
            int max = GetMaximum();
            float center = (min + max) / 2;

            camera._pos = new Vector2(center, 0);
            this.Update();
        }

        /// <summary>
        /// Returns the maximum number for the track segments
        /// </summary>
        /// <returns></returns>
        private int GetMaximum()
        {
            if (TrackLayout.Track.Count == 0)
            {
                return (0);
            }
            else
            {
                int min = Int32.MaxValue;
                foreach (TrackSegment track in TrackLayout.Track)
                {
                    if (track.BrakeLocation < min)
                    {
                        min = track.BrakeLocation;
                    }
                    if (track.TargetLocation < min)
                    {
                        min = track.TargetLocation;
                    }
                }
                return (min);
            }
        }

        /// <summary>
        /// Returns the minimum number for the track segments
        /// </summary>
        /// <returns></returns>
        private int GetMinimum()
        {
            if (TrackLayout.Track.Count == 0)
            {
                return (0);
            }
            else
            {
                int max = Int32.MinValue;
                foreach (TrackSegment track in TrackLayout.Track)
                {
                    if (track.BrakeLocation > max)
                    {
                        max = track.BrakeLocation;
                    }
                    if (track.TargetLocation > max)
                    {
                        max = track.TargetLocation;
                    }
                }
                return (max);
            }
        }



    }
}