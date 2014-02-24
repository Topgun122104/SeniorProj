using Microsoft.Xna.Framework;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace RailRoadSignal.EditorForms
{
    public partial class Railroad_Signal : Form
    {
        /// <summary>
        /// Initialize all the componenets for the application
        /// </summary>
        public Railroad_Signal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The mainloop for the display window
        /// keeps the update at a constant rate of ~60 fps
        /// </summary>
        public void MainLoop()
        {
            long ticks1 = 0;
            long ticks2 = 0;
            double interval = (double)Stopwatch.Frequency / 60.0;

            while (!this.IsDisposed)
            {
                Application.DoEvents();
                ticks2 = Stopwatch.GetTimestamp();
                if (ticks2 >= ticks1 + interval)
                {
                    GameTime gameTime = new GameTime(new TimeSpan(ticks2), new TimeSpan(ticks2 - ticks1));
                    ticks1 = Stopwatch.GetTimestamp();
                    displayWindow1.Update(gameTime);
                    //Refresh();
                }
            }
        }

        /// <summary>
        /// Bool for the aplication is running
        /// </summary>
        protected bool isRunning;

        /// <summary>
        /// Paint event for the window
        /// </summary>
        /// <param name="sender">Object</param>
        /// <param name="e">PaintEventArgs</param>
        private void Railroad_Signal_Paint(object sender, PaintEventArgs e)
        {
            if (!isRunning)
            {
                isRunning = true;
                MainLoop();
            }
        }

        /// <summary>
        /// Exit the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // example files
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // make the track view visible
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // make the data view visible
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // example files
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }




    }
}
