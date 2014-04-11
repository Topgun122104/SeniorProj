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
            this.Circuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeadwayCalculation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RuntimePerformance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClearTimeCalculation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApproachLockingTimeCalculation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ProjectNameBox = new System.Windows.Forms.TextBox();
            this.PostRangeBox = new System.Windows.Forms.TextBox();
            this.MaxSpeedBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.TonnageBox = new System.Windows.Forms.TextBox();
            this.MaxBlockLengthBox = new System.Windows.Forms.TextBox();
            this.BreakingCharBox = new System.Windows.Forms.TextBox();
            this.NotesBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrackSegmentName,
            this.Circuit,
            this.SBD,
            this.HeadwayCalculation,
            this.RuntimePerformance,
            this.ClearTimeCalculation,
            this.ApproachLockingTimeCalculation});
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 579);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // TrackSegmentName
            // 
            this.TrackSegmentName.HeaderText = "Track Segment ID";
            this.TrackSegmentName.Name = "TrackSegmentName";
            this.TrackSegmentName.Width = 120;
            // 
            // Circuit
            // 
            this.Circuit.HeaderText = "Circuit";
            this.Circuit.Name = "Circuit";
            // 
            // SBD
            // 
            this.SBD.HeaderText = "Safe Breaking Distance";
            this.SBD.Name = "SBD";
            this.SBD.Width = 150;
            // 
            // HeadwayCalculation
            // 
            this.HeadwayCalculation.HeaderText = "Headway Calculation";
            this.HeadwayCalculation.Name = "HeadwayCalculation";
            this.HeadwayCalculation.Width = 150;
            // 
            // RuntimePerformance
            // 
            this.RuntimePerformance.HeaderText = "Runtime Performance";
            this.RuntimePerformance.Name = "RuntimePerformance";
            this.RuntimePerformance.Width = 150;
            // 
            // ClearTimeCalculation
            // 
            this.ClearTimeCalculation.HeaderText = "Clear Time Calculation";
            this.ClearTimeCalculation.Name = "ClearTimeCalculation";
            this.ClearTimeCalculation.Width = 150;
            // 
            // ApproachLockingTimeCalculation
            // 
            this.ApproachLockingTimeCalculation.HeaderText = "Approach Locking Time Calculation";
            this.ApproachLockingTimeCalculation.Name = "ApproachLockingTimeCalculation";
            this.ApproachLockingTimeCalculation.Width = 175;
            // 
            // CustomerBox
            // 
            this.CustomerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerBox.BackColor = System.Drawing.Color.White;
            this.CustomerBox.Location = new System.Drawing.Point(1194, 108);
            this.CustomerBox.Name = "CustomerBox";
            this.CustomerBox.ReadOnly = true;
            this.CustomerBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1126, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1105, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Project Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1113, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Post Range";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1115, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Max Speed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1145, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1126, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tonnage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1083, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Max Block Length";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1055, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Breaking Characteristics";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1058, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Notes";
            // 
            // ProjectNameBox
            // 
            this.ProjectNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectNameBox.BackColor = System.Drawing.Color.White;
            this.ProjectNameBox.Location = new System.Drawing.Point(1194, 149);
            this.ProjectNameBox.Name = "ProjectNameBox";
            this.ProjectNameBox.ReadOnly = true;
            this.ProjectNameBox.Size = new System.Drawing.Size(100, 20);
            this.ProjectNameBox.TabIndex = 11;
            // 
            // PostRangeBox
            // 
            this.PostRangeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostRangeBox.BackColor = System.Drawing.Color.White;
            this.PostRangeBox.Location = new System.Drawing.Point(1194, 186);
            this.PostRangeBox.Name = "PostRangeBox";
            this.PostRangeBox.ReadOnly = true;
            this.PostRangeBox.Size = new System.Drawing.Size(100, 20);
            this.PostRangeBox.TabIndex = 12;
            // 
            // MaxSpeedBox
            // 
            this.MaxSpeedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxSpeedBox.BackColor = System.Drawing.Color.White;
            this.MaxSpeedBox.Location = new System.Drawing.Point(1194, 231);
            this.MaxSpeedBox.Name = "MaxSpeedBox";
            this.MaxSpeedBox.ReadOnly = true;
            this.MaxSpeedBox.Size = new System.Drawing.Size(100, 20);
            this.MaxSpeedBox.TabIndex = 13;
            // 
            // TypeBox
            // 
            this.TypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeBox.BackColor = System.Drawing.Color.White;
            this.TypeBox.Location = new System.Drawing.Point(1194, 272);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.ReadOnly = true;
            this.TypeBox.Size = new System.Drawing.Size(100, 20);
            this.TypeBox.TabIndex = 14;
            // 
            // TonnageBox
            // 
            this.TonnageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TonnageBox.BackColor = System.Drawing.Color.White;
            this.TonnageBox.Location = new System.Drawing.Point(1194, 309);
            this.TonnageBox.Name = "TonnageBox";
            this.TonnageBox.ReadOnly = true;
            this.TonnageBox.Size = new System.Drawing.Size(100, 20);
            this.TonnageBox.TabIndex = 15;
            // 
            // MaxBlockLengthBox
            // 
            this.MaxBlockLengthBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxBlockLengthBox.BackColor = System.Drawing.Color.White;
            this.MaxBlockLengthBox.Location = new System.Drawing.Point(1194, 352);
            this.MaxBlockLengthBox.Name = "MaxBlockLengthBox";
            this.MaxBlockLengthBox.ReadOnly = true;
            this.MaxBlockLengthBox.Size = new System.Drawing.Size(100, 20);
            this.MaxBlockLengthBox.TabIndex = 16;
            // 
            // BreakingCharBox
            // 
            this.BreakingCharBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BreakingCharBox.BackColor = System.Drawing.Color.White;
            this.BreakingCharBox.Location = new System.Drawing.Point(1194, 399);
            this.BreakingCharBox.Name = "BreakingCharBox";
            this.BreakingCharBox.ReadOnly = true;
            this.BreakingCharBox.Size = new System.Drawing.Size(100, 20);
            this.BreakingCharBox.TabIndex = 17;
            // 
            // NotesBox
            // 
            this.NotesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesBox.BackColor = System.Drawing.Color.White;
            this.NotesBox.Location = new System.Drawing.Point(1061, 477);
            this.NotesBox.Name = "NotesBox";
            this.NotesBox.ReadOnly = true;
            this.NotesBox.Size = new System.Drawing.Size(233, 161);
            this.NotesBox.TabIndex = 18;
            this.NotesBox.Text = "";
            // 
            // DataViewForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1370, 650);
            this.ControlBox = false;
            this.Controls.Add(this.NotesBox);
            this.Controls.Add(this.BreakingCharBox);
            this.Controls.Add(this.MaxBlockLengthBox);
            this.Controls.Add(this.TonnageBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.MaxSpeedBox);
            this.Controls.Add(this.PostRangeBox);
            this.Controls.Add(this.ProjectNameBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerBox);
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
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox ProjectNameBox;
        public System.Windows.Forms.TextBox PostRangeBox;
        public System.Windows.Forms.TextBox MaxSpeedBox;
        public System.Windows.Forms.TextBox TypeBox;
        public System.Windows.Forms.TextBox TonnageBox;
        public System.Windows.Forms.TextBox MaxBlockLengthBox;
        public System.Windows.Forms.TextBox BreakingCharBox;
        private System.Windows.Forms.RichTextBox NotesBox;
        public System.Windows.Forms.TextBox CustomerBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackSegmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Circuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeadwayCalculation;
        private System.Windows.Forms.DataGridViewTextBoxColumn RuntimePerformance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClearTimeCalculation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApproachLockingTimeCalculation;



    }
}