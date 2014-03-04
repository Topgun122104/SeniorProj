﻿using Microsoft.Xna.Framework;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RailRoadSignal
{
    public partial class TrackViewDisplay : Form
    {
        GameTime gameTime;
        public TrackViewDisplay()
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
                    gameTime = new GameTime(new TimeSpan(ticks2), new TimeSpan(ticks2 - ticks1));
                    ticks1 = Stopwatch.GetTimestamp();
                    displayWindow1.Update(gameTime);
                    Refresh();
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
         
    }
}