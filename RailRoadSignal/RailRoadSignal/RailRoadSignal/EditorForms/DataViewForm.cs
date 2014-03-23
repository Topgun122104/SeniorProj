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
    public partial class DataViewForm : Form
    {
        public DataViewForm()
        {
            InitializeComponent();



        }
        public void ClearDataView()
        {

            this.dataGridView1.DataBindings.Clear();
            this.dataGridView1.Rows.Clear();
            
        }
        public void UpdateDataView()
        {
            ClearDataView();

            foreach (var x in TrackLayout.Track)
            {
                this.dataGridView1.Rows.Add(x.TrackID, x.SafeBreakingDistance, x.Headway, x.RuntimePerformance, x.ClearTime, x.ApproachLockingTime);
            }
        }
        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
