
using OpenTK.Graphics;
namespace Signal_Block_Design_Tool.Forms
{
    partial class TrackViewForm
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
            this.GoTrackButton = new System.Windows.Forms.Button();
            this.glControl1 = new OpenTK.GLControl(new GraphicsMode(32, 24, 8, 4), 4, 0, GraphicsContextFlags.ForwardCompatible);
            this.SuspendLayout();
            // 
            // GoTrackButton
            // 
            this.GoTrackButton.Location = new System.Drawing.Point(1257, 13);
            this.GoTrackButton.Name = "GoTrackButton";
            this.GoTrackButton.Size = new System.Drawing.Size(75, 23);
            this.GoTrackButton.TabIndex = 8;
            this.GoTrackButton.Text = "Go to track";
            this.GoTrackButton.UseVisualStyleBackColor = true;
            this.GoTrackButton.Click += new System.EventHandler(this.GoToTrackButton_Click);
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(13, 13);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(1143, 636);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.glControl1_KeyDown);
            this.glControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseDown);
            this.glControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseMove);
            this.glControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseUp);
            this.glControl1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseWheel);
            this.glControl1.Resize += new System.EventHandler(this.glControl1_Resize);
            // 
            // TrackViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 661);
            this.ControlBox = false;
            this.Controls.Add(this.GoTrackButton);
            this.Controls.Add(this.glControl1);
            this.Name = "TrackViewForm";
            this.Text = "TrackViewForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GoTrackButton;
        private OpenTK.GLControl glControl1;



    }
}