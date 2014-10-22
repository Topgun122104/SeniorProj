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
                TreeNode[] children = new TreeNode[16];
                children[0] = new TreeNode("Direction: " + t.Direction.ToString());
                children[1] = new TreeNode("Move: " + t.Move.ToString());
                children[2] = new TreeNode("Start Point: " + t.StartPoint.ToString());
                children[3] = new TreeNode("End Point: " + t.EndPoint.ToString());
                children[4] = new TreeNode("Brake Location: " + t.BrakeLocation.ToString());
                children[5] = new TreeNode("Target Location: " + t.TargetLocation.ToString());
                children[6] = new TreeNode("Grade Worst: " + t.GradeWorst.ToString());
                children[7] = new TreeNode("Speed Max: " + t.SpeedMax.ToString());
                children[8] = new TreeNode("Overspeed: " + t.OverSpeed.ToString());
                children[9] = new TreeNode("Vehicle Accel: " + t.VehicleAccel.ToString());
                children[10] = new TreeNode("Reaction Time: " + t.ReactionTime.ToString());
                children[11] = new TreeNode("Brake Rate: " + t.BrakeRate.ToString());
                children[12] = new TreeNode("Runaway Accel: " + t.RunwayAccelSec.ToString());
                children[13] = new TreeNode("Propulsion Rem: " + t.PropulsionRemSec.ToString());
                children[14] = new TreeNode("Brake Build Up: " + t.BrakeBuildUpSec.ToString());
                children[15] = new TreeNode("Overhang Distance: " + t.OverhangDist.ToString());
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
            this.dataGridView2.DataBindings.Clear();
            this.dataGridView2.Rows.Clear();

        }
        /// <summary>
        /// 
        /// </summary>
        public void UpdateDataView()
        {
            ClearDataView();
            dataGridView2.ColumnCount = 16;
            dataGridView2.Columns[0].Name = "TrackCircuit:";
            dataGridView2.Columns[1].Name = "Direction:";
            dataGridView2.Columns[2].Name = "Move:";
            dataGridView2.Columns[3].Name = "Brake Location: ";
            dataGridView2.Columns[4].Name = "Target Location: ";
            dataGridView2.Columns[5].Name = "Grade Worst: ";
            dataGridView2.Columns[6].Name = "Speed Max: ";
            dataGridView2.Columns[7].Name = "Overspeed: ";
            dataGridView2.Columns[8].Name = "Vehicle Accel: ";
            dataGridView2.Columns[9].Name = "Reaction Time: ";
            dataGridView2.Columns[10].Name = "Brake Rate: ";
            dataGridView2.Columns[11].Name = "Runaway Accel: ";
            dataGridView2.Columns[12].Name = "Propulsion Rem: ";
            dataGridView2.Columns[13].Name = "Brake Build Up: ";
            dataGridView2.Columns[14].Name = "Overhang Distance: ";
            dataGridView2.Columns[15].Name = "Is Safe: ";
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Track Circuit";
            dataGridView1.Columns[1].Name = "Calculated Safe Breaking Distance";
            dataGridView1.Columns[2].Name = "Available Distance";
            int rowNum = 0;
            int rowIndex = 1;
            foreach (TrackSegment t in TrackLayout.Track)
            {
                this.dataGridView2.Rows.Add(t.TrackCircuit.ToString(), t.Direction.ToString(), t.Move.ToString(), t.BrakeLocation.ToString(), t.TargetLocation.ToString(),
                t.GradeWorst.ToString(), t.SpeedMax.ToString(), t.OverSpeed.ToString(), t.VehicleAccel.ToString(), t.ReactionTime.ToString(),
                t.BrakeRate.ToString(), t.RunwayAccelSec.ToString(), t.PropulsionRemSec.ToString(), t.BrakeBuildUpSec.ToString(), t.OverhangDist.ToString(), t.IsSafe.ToString());

                this.dataGridView1.Rows.Add(t.TrackCircuit.ToString(), t.SafeBreakingDistance.ToString(), t.SafeBreakingDistanceRequired.ToString());
                rowNum++;
            }

            for (int i = 0; i < rowNum; i++)
            {
                if (dataGridView2.Rows[i].Cells[15].Value.ToString() == "False")
                {
                    for (int j = 0; j < 16; j++)
                    {
                        dataGridView2.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(255, 70, 63);
                    }  
                     
                    for(int j = 0; j < 3; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(255, 70, 63);
                    }
                }
                rowIndex++;
            }
        }
    }
}