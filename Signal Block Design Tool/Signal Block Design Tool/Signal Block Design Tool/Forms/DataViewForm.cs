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
                TreeNode[] children = new TreeNode[14];

                children[0] = new TreeNode("Start Point: " + t.StartPoint.ToString());
                children[1] = new TreeNode("End Point: " + t.EndPoint.ToString());
                children[2] = new TreeNode("Brake Location: " + t.BrakeLocation.ToString());
                children[3] = new TreeNode("Target Location: " + t.TargetLocation.ToString());
                children[4] = new TreeNode("Grade Worst: " + t.GradeWorst.ToString());
                children[5] = new TreeNode("Speed Max: " + t.SpeedMax.ToString());
                children[6] = new TreeNode("Overspeed: " + t.OverSpeed.ToString());
                children[7] = new TreeNode("Vehicle Accel: " + t.VehicleAccel.ToString());
                children[8] = new TreeNode("Reaction Time: " + t.ReactionTime.ToString());
                children[9] = new TreeNode("Brake Rate: " + t.BrakeRate.ToString());
                children[10] = new TreeNode("Runaway Accel: " + t.RunwayAccelSec.ToString());
                children[11] = new TreeNode("Propulsion Rem: " + t.PropulsionRemSec.ToString());
                children[12] = new TreeNode("Brake Build Up: " + t.BrakeBuildUpSec.ToString());
                children[13] = new TreeNode("Overhang Distance: " + t.OverhangDist.ToString());

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
            BindingSource trackLayoutBindingSource = new BindingSource();
            trackLayoutBindingSource.DataSource = TrackLayout.Track;

           
            dataGridView2.DataSource = trackLayoutBindingSource;
            
            foreach(TrackSegment t in TrackLayout.Track)
            {
                this.dataGridView1.Rows.Add(t.TrackCircuit.ToString(), t.SafeBreakingDistance.ToString());
            }

        }
    }
}
