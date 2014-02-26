namespace RailRoadSignal
{
    partial class TrackViewDisplay
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayWindow1 = new RailRoadSignal.CustomControls.DisplayWindow();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1104, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 626);
            this.panel1.TabIndex = 4;
            // 
            // displayWindow1
            // 
            this.displayWindow1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayWindow1.Location = new System.Drawing.Point(12, 12);
            this.displayWindow1.Name = "displayWindow1";
            this.displayWindow1.Size = new System.Drawing.Size(1086, 626);
            this.displayWindow1.TabIndex = 3;
            this.displayWindow1.Text = "displayWindow1";
            // 
            // TrackViewDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.displayWindow1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrackViewDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Track View Display";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Railroad_Signal_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.DisplayWindow displayWindow1;
        private System.Windows.Forms.Panel panel1;
    }
}