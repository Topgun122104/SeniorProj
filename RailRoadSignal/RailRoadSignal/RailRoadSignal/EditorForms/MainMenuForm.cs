﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RailRoadSignal.EditorForms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create a new track
            this.Visible = false;
            NewTrackLayoutForm newTrackLayout = new NewTrackLayoutForm();
            newTrackLayout.Show();

             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // load a track from the database
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // load a local saved track
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // example files
             
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

        private void button4_Click(object sender, EventArgs e)
        {
            // nothing yet
        }
    }
}