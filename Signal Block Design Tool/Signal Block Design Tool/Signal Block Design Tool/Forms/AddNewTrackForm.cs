using Signal_Block_Design_Tool.Files;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signal_Block_Design_Tool.Forms
{
    public partial class AddNewTrackForm : Form
    {
        public AddNewTrackForm()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            TrackLayout.Track.Add(new TrackSegment
            {
                Direction = this.DirectionBox.Text,
                Move = this.MoveBox.Text,
                TrackCircuit = this.TrackCircuitBox.Text,
                BrakeLocation = int.Parse(this.BrakeLocationBox.Text),
                TargetLocation = int.Parse(this.TargetLocationBox.Text),
                GradeWorst = double.Parse(this.GradeWorstBox.Text),
                SpeedMax = double.Parse(this.SpeedMaxBox.Text),
                OverSpeed = double.Parse(this.OverSpeedBox.Text),
                VehicleAccel = double.Parse(this.VehicleAccelBox.Text),
                ReactionTime = double.Parse(this.ReactionTimeBox.Text),
                BrakeRate = double.Parse(this.BrakeRateBox.Text),
                RunwayAccelSec = double.Parse(this.RunwayAcelSecBox.Text),
                PropulsionRemSec = double.Parse(this.PropulsionRemSecBox.Text),
                BrakeBuildUpSec = int.Parse(this.BrakeBuildUpSecBox.Text),
                OverhangDist = int.Parse(this.OverhangDistanceBox.Text)
            });
        }
    }
}
