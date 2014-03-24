using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RailRoadSignal.Files;

namespace RailRoadSignal.EditorForms
{
    public partial class NewTrackLayoutForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public NewTrackLayoutForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Accept button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KilometersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TrackLayout.Kilometers = true;
            TrackLayout.Miles = false;
            MilesCheckBox.Checked = false;
        }

        private void MilesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TrackLayout.Miles = true;
            TrackLayout.Kilometers = false;
            KilometersCheckBox.Checked = false;
           
        }
    }
}
