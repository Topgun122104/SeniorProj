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
                this.dataGridView1.Rows.Add(x.TrackID, x.TrackCircuit, x.SafeBreakingDistance, x.Headway, x.RuntimePerformance, x.ClearTime, x.ApproachLockingTime);
            }
        }
    }
}
