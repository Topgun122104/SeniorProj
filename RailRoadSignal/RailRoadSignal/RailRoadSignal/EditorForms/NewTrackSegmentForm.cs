using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RailRoadSignal.EditorForms
{
    public partial class NewTrackSegmentForm : Form
    {
        public NewTrackSegmentForm()
        {
            InitializeComponent();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            // add the new piece of track to the list
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Cancel the track piece.
            this.Close();
        }
    }
}
