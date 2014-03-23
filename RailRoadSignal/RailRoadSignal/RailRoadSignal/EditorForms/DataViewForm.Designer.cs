namespace RailRoadSignal.EditorForms
{
    partial class DataViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TrackSegmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeadwayCalculation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RuntimePerformance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClearTimeCalculation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApproachLockingTimeCalculation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrackSegmentName,
            this.SBD,
            this.HeadwayCalculation,
            this.RuntimePerformance,
            this.ClearTimeCalculation,
            this.ApproachLockingTimeCalculation});
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1346, 579);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // TrackSegmentName
            // 
            this.TrackSegmentName.HeaderText = "Track Segment ID";
            this.TrackSegmentName.Name = "TrackSegmentName";
            this.TrackSegmentName.ReadOnly = true;
            this.TrackSegmentName.Width = 200;
            // 
            // SBD
            // 
            this.SBD.HeaderText = "Safe Breaking Distance";
            this.SBD.Name = "SBD";
            this.SBD.ReadOnly = true;
            this.SBD.Width = 200;
            // 
            // HeadwayCalculation
            // 
            this.HeadwayCalculation.HeaderText = "Headway Calculation";
            this.HeadwayCalculation.Name = "HeadwayCalculation";
            this.HeadwayCalculation.ReadOnly = true;
            this.HeadwayCalculation.Width = 200;
            // 
            // RuntimePerformance
            // 
            this.RuntimePerformance.HeaderText = "Runtime Performance";
            this.RuntimePerformance.Name = "RuntimePerformance";
            this.RuntimePerformance.ReadOnly = true;
            this.RuntimePerformance.Width = 200;
            // 
            // ClearTimeCalculation
            // 
            this.ClearTimeCalculation.HeaderText = "Clear Time Calculation";
            this.ClearTimeCalculation.Name = "ClearTimeCalculation";
            this.ClearTimeCalculation.ReadOnly = true;
            this.ClearTimeCalculation.Width = 200;
            // 
            // ApproachLockingTimeCalculation
            // 
            this.ApproachLockingTimeCalculation.HeaderText = "Approach Locking Time Calculation";
            this.ApproachLockingTimeCalculation.Name = "ApproachLockingTimeCalculation";
            this.ApproachLockingTimeCalculation.ReadOnly = true;
            this.ApproachLockingTimeCalculation.Width = 200;
            // 
            // DataViewForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1370, 650);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataViewForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DataViewForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackSegmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeadwayCalculation;
        private System.Windows.Forms.DataGridViewTextBoxColumn RuntimePerformance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClearTimeCalculation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApproachLockingTimeCalculation;



    }
}