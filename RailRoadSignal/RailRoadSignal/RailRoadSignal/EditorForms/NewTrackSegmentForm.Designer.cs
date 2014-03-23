namespace RailRoadSignal.EditorForms
{
    partial class NewTrackSegmentForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.startPositionXBox = new System.Windows.Forms.TextBox();
            this.startPositionYBox = new System.Windows.Forms.TextBox();
            this.endPositionXBox = new System.Windows.Forms.TextBox();
            this.endPositionYBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(309, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Accept";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(13, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // startPositionXBox
            // 
            this.startPositionXBox.Location = new System.Drawing.Point(104, 12);
            this.startPositionXBox.Name = "startPositionXBox";
            this.startPositionXBox.Size = new System.Drawing.Size(100, 20);
            this.startPositionXBox.TabIndex = 2;
            // 
            // startPositionYBox
            // 
            this.startPositionYBox.Location = new System.Drawing.Point(210, 12);
            this.startPositionYBox.Name = "startPositionYBox";
            this.startPositionYBox.Size = new System.Drawing.Size(100, 20);
            this.startPositionYBox.TabIndex = 3;
            // 
            // endPositionXBox
            // 
            this.endPositionXBox.Location = new System.Drawing.Point(104, 38);
            this.endPositionXBox.Name = "endPositionXBox";
            this.endPositionXBox.Size = new System.Drawing.Size(100, 20);
            this.endPositionXBox.TabIndex = 4;
            // 
            // endPositionYBox
            // 
            this.endPositionYBox.Location = new System.Drawing.Point(210, 38);
            this.endPositionYBox.Name = "endPositionYBox";
            this.endPositionYBox.Size = new System.Drawing.Size(100, 20);
            this.endPositionYBox.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(13, 119);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 6;
            // 
            // NewTrackSegmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 355);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.endPositionYBox);
            this.Controls.Add(this.endPositionXBox);
            this.Controls.Add(this.startPositionYBox);
            this.Controls.Add(this.startPositionXBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "NewTrackSegmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Track";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.TextBox startPositionXBox;
        public System.Windows.Forms.TextBox startPositionYBox;
        public System.Windows.Forms.TextBox endPositionXBox;
        public System.Windows.Forms.TextBox endPositionYBox;
    }
}