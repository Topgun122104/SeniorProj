using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using RailRoadSignal.Files;

namespace RailRoadSignal.CustomControls
{
    /// <summary>
    /// This is 
    /// </summary>
    public class DisplayWindow : WinFormsGraphicsDevice.GraphicsDeviceControl
    {
        // The height and width for the camera
        private const int WINDOWHEIGHT = 720;
        private const int WINDOWWIDTH = 1280;

        // Variables for loading(XNA) content
        private ContentManager Content;
        private SpriteBatch spriteBatch;
        private SpriteFont testFont;
        private SpriteFont displayFont;
        private Texture2D whiteTexture;
        private Texture2D arrowTexture;

        // Mouse position information (XNA)
        private MouseState m_currMouseState;
        private MouseState m_prevMouseState;
        private Ray m_mouseRay;
        private Vector3 NearSource;
        private Vector3 FarSource;
        private Vector3 NearPoint;
        private Vector3 FarPoint;

        // Create a new view camera for the display window
        private View m_view;

        // Timespan object to display in the display window
        private TimeSpan m_currentTime;

        /*******************************************************/

        string error = "";
        bool ViewError = false;
        /// <summary>
        /// Initialize the display window and all of the contents
        /// </summary>
        protected override void Initialize()
        {
            // create a new content manager for loading content
            Content = new ContentManager(Services, "Content");
            // create a new spritebatch for drawing
            spriteBatch = new SpriteBatch(GraphicsDevice);
            // create a new view to be able to move around
            m_view = new View(WINDOWWIDTH,              // The width of the display (1280)
                                WINDOWHEIGHT,           // The height of the display (720)
                                new Vector2(100, 100),  // The starting location of the view
                                0.5f,                   // Minimum zoom amount
                                3.0f);                  // MAximum zoom amount

            // Mouse state and mouse event handler
            m_currMouseState = Mouse.GetState();
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.UpdateMouseWheel);


            // load all the textures and fonts
            Load(Content);



            // Add the sample track
            
        }


        /// <summary>
        /// Load all the content for the graphics and fonts
        /// </summary>
        /// <param name="content"></param>
        private void Load(ContentManager content)
        {
            testFont = content.Load<SpriteFont>("Fonts\\testFont");
            displayFont = content.Load<SpriteFont>("Fonts\\DisplayFont");
            whiteTexture = content.Load<Texture2D>("Textures\\2x2White");
            arrowTexture = content.Load<Texture2D>("Textures\\arrow");
        }


        private void AddSampleTrack()
        {
           
        }

        /// <summary>
        /// Update method for the graphics window
        /// </summary>
        /// <param name="gameTime"></param>
        public void Update(GameTime gameTime)
        {
            this.Refresh();
            UpdateView();
            m_currentTime = gameTime.TotalGameTime;
            /************************************************/

            // m_mouseRay = new Ray(new Vector3(m_currMouseState.X, m_currMouseState.Y, 0), new Vector3());

            NearSource = new Vector3((float)m_currMouseState.X, m_currMouseState.Y, 0f);
            FarSource = new Vector3((float)m_currMouseState.X, m_currMouseState.Y, 1f);

            // NearPoint = GraphicsDevice.Viewport.Unproject(NearSource, )


        }
        /// <summary>
        /// Updates the view according to the mouse position
        /// </summary>
        private void UpdateView()
        {
            try
            {
                // get the current mouse position
                m_currMouseState = Mouse.GetState();
                int currScrollValue = Mouse.GetState().ScrollWheelValue;


                if (Keyboard.GetState().IsKeyDown(Keys.Add))
                {
                    m_view.Zoom += 0.05f;
                }
                // if the left button is pressed, move the view
                if (m_currMouseState.LeftButton == ButtonState.Pressed)
                {
                    if (m_currMouseState.X > m_prevMouseState.X)
                    {
                        m_view.MoveLeft((m_currMouseState.X - m_prevMouseState.X) / m_view.Zoom);
                    }
                    if (m_currMouseState.X < m_prevMouseState.X)
                    {
                        m_view.MoveRight((m_prevMouseState.X - m_currMouseState.X) / m_view.Zoom);
                    }
                    if (m_currMouseState.Y < m_prevMouseState.Y)
                    {
                        m_view.MoveUp((m_prevMouseState.Y - m_currMouseState.Y) / m_view.Zoom);
                    }
                    if (m_currMouseState.Y > m_prevMouseState.Y)
                    {
                        m_view.MoveDown((m_currMouseState.Y - m_prevMouseState.Y) / m_view.Zoom);
                    }
                }

                ViewError = false;

            }
            catch (Exception e)
            {
                // do nothing
                ViewError = true;
                error = e.ToString();

            }
            // Set the previous mouse state to the current mouse state
            m_prevMouseState = m_currMouseState;

            Refresh();
        }

        /// <summary>
        /// Handles the scroll wheel information and the Zoom for the veiw
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateMouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Mouse scroll wheel information (Windows Forms)
            if (e.Delta >= 0)
            {
                m_view.Zoom += 0.05f;
            }
            if (e.Delta <= 0)
            {
                m_view.Zoom -= 0.05f;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="line"></param>
        /// <param name="ray"></param>
        /// <returns></returns>
        private bool MouseIntersects(Line line, Ray ray)
        {

            return false;

        }

        public void SetView(Vector2 position)
        {
            m_view.Move(position);
        }
        /// <summary>
        /// All of the rendering of graphics go in here
        /// </summary>
        protected override void Draw()
        {

            // Clears the view and sets the background to black
            GraphicsDevice.Clear(Color.Black);

            // Display items that are not updated with the view here
            spriteBatch.Begin();
            spriteBatch.DrawString(displayFont, "view X : " + m_view.Position.X, new Vector2(20, 0), Color.Yellow);
            spriteBatch.DrawString(displayFont, "view Y : " + m_view.Position.Y, new Vector2(20, 10), Color.Yellow);
            spriteBatch.DrawString(displayFont, "mouse X: " + m_currMouseState.X, new Vector2(20, 20), Color.Yellow);
            spriteBatch.DrawString(displayFont, "mouse Y: " + m_currMouseState.Y, new Vector2(20, 30), Color.Yellow);
            spriteBatch.DrawString(displayFont, "zoom   : " + m_view.Zoom, new Vector2(20, 40), Color.Yellow);
            if (ViewError)
            {
                spriteBatch.DrawString(displayFont, error, new Vector2(Width / 2, Height / 2), Color.Yellow);
            }
            spriteBatch.End();


            // display anything that gets updated with the view here
            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend,
                   SamplerState.PointClamp, null, null, null, m_view.getTransformation(GraphicsDevice));


            /*************************************************/

            foreach (TrackSegment track in TrackLayout.Track)
            {
                track.Draw(whiteTexture, arrowTexture, spriteBatch, Color.Red);

            }
            spriteBatch.End();
        }
    }
}
