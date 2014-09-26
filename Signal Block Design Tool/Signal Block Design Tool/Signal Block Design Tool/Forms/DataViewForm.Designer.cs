namespace Signal_Block_Design_Tool.Forms
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
               this.TabbedControl = new System.Windows.Forms.TabControl();
               this.CalculationsTab = new System.Windows.Forms.TabPage();
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.Circuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.SBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.TrackSegmentsTab = new System.Windows.Forms.TabPage();
               this.dataGridView2 = new System.Windows.Forms.DataGridView();
               this.GeneralTab = new System.Windows.Forms.TabPage();
               this.treeView1 = new System.Windows.Forms.TreeView();
               this.TabbedControl.SuspendLayout();
               this.CalculationsTab.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               this.TrackSegmentsTab.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
               this.SuspendLayout();
               // 
               // TabbedControl
               // 
               this.TabbedControl.Controls.Add(this.CalculationsTab);
               this.TabbedControl.Controls.Add(this.TrackSegmentsTab);
               this.TabbedControl.Controls.Add(this.GeneralTab);
               this.TabbedControl.Location = new System.Drawing.Point(12, 12);
               this.TabbedControl.Name = "TabbedControl";
               this.TabbedControl.SelectedIndex = 0;
               this.TabbedControl.Size = new System.Drawing.Size(1083, 637);
               this.TabbedControl.TabIndex = 1;
               // 
               // CalculationsTab
               // 
               this.CalculationsTab.Controls.Add(this.dataGridView1);
               this.CalculationsTab.Location = new System.Drawing.Point(4, 22);
               this.CalculationsTab.Name = "CalculationsTab";
               this.CalculationsTab.Padding = new System.Windows.Forms.Padding(3);
               this.CalculationsTab.Size = new System.Drawing.Size(1075, 611);
               this.CalculationsTab.TabIndex = 0;
               this.CalculationsTab.Text = "Calculations";
               this.CalculationsTab.UseVisualStyleBackColor = true;
               // 
               // dataGridView1
               // 
               this.dataGridView1.AllowUserToOrderColumns = true;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Circuit,
            this.SBD});
               this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.dataGridView1.Location = new System.Drawing.Point(3, 3);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.Size = new System.Drawing.Size(1069, 605);
               this.dataGridView1.TabIndex = 0;
               // 
               // Circuit
               // 
               this.Circuit.HeaderText = "Circuit";
               this.Circuit.Name = "Circuit";
               this.Circuit.ReadOnly = true;
               this.Circuit.Width = 150;
               // 
               // SBD
               // 
               this.SBD.HeaderText = "Safe Breaking Distance";
               this.SBD.Name = "SBD";
               this.SBD.ReadOnly = true;
               this.SBD.Width = 150;
               // 
               // TrackSegmentsTab
               // 
               this.TrackSegmentsTab.Controls.Add(this.dataGridView2);
               this.TrackSegmentsTab.Location = new System.Drawing.Point(4, 22);
               this.TrackSegmentsTab.Name = "TrackSegmentsTab";
               this.TrackSegmentsTab.Padding = new System.Windows.Forms.Padding(3);
               this.TrackSegmentsTab.Size = new System.Drawing.Size(1075, 611);
               this.TrackSegmentsTab.TabIndex = 1;
               this.TrackSegmentsTab.Text = "Track Segments";
               this.TrackSegmentsTab.UseVisualStyleBackColor = true;
               // 
               // dataGridView2
               // 
               this.dataGridView2.AllowUserToOrderColumns = true;
               this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
               this.dataGridView2.Location = new System.Drawing.Point(3, 3);
               this.dataGridView2.Name = "dataGridView2";
               this.dataGridView2.Size = new System.Drawing.Size(1069, 605);
               this.dataGridView2.TabIndex = 0;
               // 
               // GeneralTab
               // 
               this.GeneralTab.Location = new System.Drawing.Point(4, 22);
               this.GeneralTab.Name = "GeneralTab";
               this.GeneralTab.Padding = new System.Windows.Forms.Padding(3);
               this.GeneralTab.Size = new System.Drawing.Size(1075, 611);
               this.GeneralTab.TabIndex = 2;
               this.GeneralTab.Text = "General";
               this.GeneralTab.UseVisualStyleBackColor = true;
               // 
               // treeView1
               // 
               this.treeView1.AllowDrop = true;
               this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.treeView1.FullRowSelect = true;
               this.treeView1.HotTracking = true;
               this.treeView1.LabelEdit = true;
               this.treeView1.Location = new System.Drawing.Point(1101, 34);
               this.treeView1.Name = "treeView1";
               this.treeView1.Size = new System.Drawing.Size(241, 615);
               this.treeView1.TabIndex = 2;
               // 
               // DataViewForm
               // 
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
               this.ClientSize = new System.Drawing.Size(1354, 661);
               this.ControlBox = false;
               this.Controls.Add(this.treeView1);
               this.Controls.Add(this.TabbedControl);
               this.DoubleBuffered = true;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
               this.Name = "DataViewForm";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
               this.Text = "DataViewForm";
               this.TabbedControl.ResumeLayout(false);
               this.CalculationsTab.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               this.TrackSegmentsTab.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
               this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabbedControl;
        private System.Windows.Forms.TabPage CalculationsTab;
        private System.Windows.Forms.TabPage TrackSegmentsTab;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage GeneralTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Circuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SBD;
    }
}