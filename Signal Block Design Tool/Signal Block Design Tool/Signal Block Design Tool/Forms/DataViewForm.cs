using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Signal_Block_Design_Tool.Files;

namespace Signal_Block_Design_Tool.Forms
{
    public partial class DataViewForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public DataViewForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        public void ClearTreeView()
        {
            this.treeView1.DataBindings.Clear();
            this.treeView1.Nodes.Clear();

        }

        /// <summary>
        /// 
        /// </summary>
        public void UpdateTreeView()
        {
            ClearTreeView();
            foreach (TrackSegment t in TrackLayout.Track)
            {
                TreeNode[] children = new TreeNode[18];

                children[0] = new TreeNode("TrackID: " + t.TrackID.ToString());
                children[1] = new TreeNode("Direction: " + t.Direction.ToString());
                children[2] = new TreeNode("Move: " + t.Move.ToString());
                children[3] = new TreeNode("Start Point: " + t.StartPoint.ToString());
                children[4] = new TreeNode("End Point: " + t.EndPoint.ToString());
                children[5] = new TreeNode("Brake Location: " + t.BrakeLocation.ToString());
                children[6] = new TreeNode("Target Location: " + t.TargetLocation.ToString());
                children[7] = new TreeNode("Grade Worst: " + t.GradeWorst.ToString());
                children[8] = new TreeNode("Speed Max: " + t.SpeedMax.ToString());
                children[9] = new TreeNode("Overspeed: " + t.OverSpeed.ToString());
                children[10] = new TreeNode("Vehicle Accel: " + t.VehicleAccel.ToString());
                children[11] = new TreeNode("Reaction Time: " + t.ReactionTime.ToString());
                children[12] = new TreeNode("Brake Rate: " + t.BrakeRate.ToString());
                children[13] = new TreeNode("Runaway Accel: " + t.RunwayAccelSec.ToString());
                children[14] = new TreeNode("Propulsion Rem: " + t.PropulsionRemSec.ToString());
                children[15] = new TreeNode("Brake Build Up: " + t.BrakeBuildUpSec.ToString());
                children[16] = new TreeNode("Overhang Distance: " + t.OverhangDist.ToString());
                children[17] = new TreeNode("Safety Factor: " + t.SafetyFact.ToString());

                TreeNode rootNode = new TreeNode("Circuit: " + t.TrackCircuit.ToString(), children);
                this.treeView1.Nodes.Add(rootNode);
                 
                

            }

        }
        /// <summary>
        /// 
        /// </summary>
        public void ClearDataView()
        {

            this.dataGridView1.DataBindings.Clear();
            this.dataGridView1.Rows.Clear();

        }
        /// <summary>
        /// 
        /// </summary>
        public void UpdateDataView()
        {
            ClearDataView();

            foreach (TrackSegment t in TrackLayout.Track)
            {
                this.dataGridView1.Rows.Add(t.TrackID.ToString(), t.TrackCircuit.ToString(), t.SafeBreakingDistance.ToString(), t.Headway.ToString());
            }
        }
    }
}
