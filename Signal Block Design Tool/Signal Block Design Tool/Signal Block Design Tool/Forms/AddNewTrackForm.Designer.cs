namespace Signal_Block_Design_Tool.Forms
{
    partial class AddNewTrackForm
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
               this.DirectionBox = new System.Windows.Forms.TextBox();
               this.MoveBox = new System.Windows.Forms.TextBox();
               this.TrackCircuitBox = new System.Windows.Forms.TextBox();
               this.BrakeLocationBox = new System.Windows.Forms.TextBox();
               this.TargetLocationBox = new System.Windows.Forms.TextBox();
               this.GradeWorstBox = new System.Windows.Forms.TextBox();
               this.SpeedMaxBox = new System.Windows.Forms.TextBox();
               this.OverSpeedBox = new System.Windows.Forms.TextBox();
               this.VehicleAccelBox = new System.Windows.Forms.TextBox();
               this.ReactionTimeBox = new System.Windows.Forms.TextBox();
               this.BrakeRateBox = new System.Windows.Forms.TextBox();
               this.RunwayAcelSecBox = new System.Windows.Forms.TextBox();
               this.PropulsionRemSecBox = new System.Windows.Forms.TextBox();
               this.BrakeBuildUpSecBox = new System.Windows.Forms.TextBox();
               this.OverhangDistanceBox = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.label7 = new System.Windows.Forms.Label();
               this.label8 = new System.Windows.Forms.Label();
               this.label9 = new System.Windows.Forms.Label();
               this.label10 = new System.Windows.Forms.Label();
               this.label11 = new System.Windows.Forms.Label();
               this.label12 = new System.Windows.Forms.Label();
               this.label13 = new System.Windows.Forms.Label();
               this.label14 = new System.Windows.Forms.Label();
               this.label15 = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // button1
               // 
               this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
               this.button1.Location = new System.Drawing.Point(413, 334);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(75, 23);
               this.button1.TabIndex = 0;
               this.button1.Text = "Close";
               this.button1.UseVisualStyleBackColor = true;
               // 
               // button2
               // 
               this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
               this.button2.Location = new System.Drawing.Point(517, 334);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(75, 23);
               this.button2.TabIndex = 1;
               this.button2.Text = "Add";
               this.button2.UseVisualStyleBackColor = true;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // TrackCircuitBox
               // 
               this.TrackCircuitBox.Location = new System.Drawing.Point(187, 76);
               this.TrackCircuitBox.Name = "TrackCircuitBox";
               this.TrackCircuitBox.Size = new System.Drawing.Size(100, 20);
               this.TrackCircuitBox.TabIndex = 2;
               // 
               // BrakeLocationBox
               // 
               this.BrakeLocationBox.Location = new System.Drawing.Point(517, 76);
               this.BrakeLocationBox.Name = "BrakeLocationBox";
               this.BrakeLocationBox.Size = new System.Drawing.Size(100, 20);
               this.BrakeLocationBox.TabIndex = 3;
               // 
               // TargetLocationBox
               // 
               this.TargetLocationBox.Location = new System.Drawing.Point(187, 109);
               this.TargetLocationBox.Name = "TargetLocationBox";
               this.TargetLocationBox.Size = new System.Drawing.Size(100, 20);
               this.TargetLocationBox.TabIndex = 4;
               // 
               // GradeWorstBox
               // 
               this.GradeWorstBox.Location = new System.Drawing.Point(517, 109);
               this.GradeWorstBox.Name = "GradeWorstBox";
               this.GradeWorstBox.Size = new System.Drawing.Size(100, 20);
               this.GradeWorstBox.TabIndex = 5;
               // 
               // SpeedMaxBox
               // 
               this.SpeedMaxBox.Location = new System.Drawing.Point(187, 145);
               this.SpeedMaxBox.Name = "SpeedMaxBox";
               this.SpeedMaxBox.Size = new System.Drawing.Size(100, 20);
               this.SpeedMaxBox.TabIndex = 6;
               // 
               // OverSpeedBox
               // 
               this.OverSpeedBox.Location = new System.Drawing.Point(517, 145);
               this.OverSpeedBox.Name = "OverSpeedBox";
               this.OverSpeedBox.Size = new System.Drawing.Size(100, 20);
               this.OverSpeedBox.TabIndex = 7;
               // 
               // VehicleAccelBox
               // 
               this.VehicleAccelBox.Location = new System.Drawing.Point(187, 180);
               this.VehicleAccelBox.Name = "VehicleAccelBox";
               this.VehicleAccelBox.Size = new System.Drawing.Size(100, 20);
               this.VehicleAccelBox.TabIndex = 8;
               // 
               // ReactionTimeBox
               // 
               this.ReactionTimeBox.Location = new System.Drawing.Point(517, 180);
               this.ReactionTimeBox.Name = "ReactionTimeBox";
               this.ReactionTimeBox.Size = new System.Drawing.Size(100, 20);
               this.ReactionTimeBox.TabIndex = 9;
               // 
               // BrakeRateBox
               // 
               this.BrakeRateBox.Location = new System.Drawing.Point(187, 218);
               this.BrakeRateBox.Name = "BrakeRateBox";
               this.BrakeRateBox.Size = new System.Drawing.Size(100, 20);
               this.BrakeRateBox.TabIndex = 10;
               // 
               // RunwayAcelSecBox
               // 
               this.RunwayAcelSecBox.Location = new System.Drawing.Point(517, 218);
               this.RunwayAcelSecBox.Name = "RunwayAcelSecBox";
               this.RunwayAcelSecBox.Size = new System.Drawing.Size(100, 20);
               this.RunwayAcelSecBox.TabIndex = 11;
               // 
               // PropulsionRemSecBox
               // 
               this.PropulsionRemSecBox.Location = new System.Drawing.Point(187, 254);
               this.PropulsionRemSecBox.Name = "PropulsionRemSecBox";
               this.PropulsionRemSecBox.Size = new System.Drawing.Size(100, 20);
               this.PropulsionRemSecBox.TabIndex = 12;
               // 
               // BrakeBuildUpSecBox
               // 
               this.BrakeBuildUpSecBox.Location = new System.Drawing.Point(517, 254);
               this.BrakeBuildUpSecBox.Name = "BrakeBuildUpSecBox";
               this.BrakeBuildUpSecBox.Size = new System.Drawing.Size(100, 20);
               this.BrakeBuildUpSecBox.TabIndex = 13;
               // 
               // OverhangDistanceBox
               // 
               this.OverhangDistanceBox.Location = new System.Drawing.Point(187, 289);
               this.OverhangDistanceBox.Name = "OverhangDistanceBox";
               this.OverhangDistanceBox.Size = new System.Drawing.Size(100, 20);
               this.OverhangDistanceBox.TabIndex = 14;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(64, 76);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(67, 13);
               this.label1.TabIndex = 15;
               this.label1.Text = "Track Circuit";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(387, 76);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(79, 13);
               this.label2.TabIndex = 16;
               this.label2.Text = "Brake Location";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(64, 109);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(82, 13);
               this.label3.TabIndex = 17;
               this.label3.Text = "Target Location";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(387, 109);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(67, 13);
               this.label4.TabIndex = 18;
               this.label4.Text = "Grade Worst";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(64, 145);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(61, 13);
               this.label5.TabIndex = 19;
               this.label5.Text = "Speed Max";
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Location = new System.Drawing.Point(387, 145);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(64, 13);
               this.label6.TabIndex = 20;
               this.label6.Text = "Over Speed";
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Location = new System.Drawing.Point(64, 183);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(72, 13);
               this.label7.TabIndex = 21;
               this.label7.Text = "Vehicle Accel";
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.Location = new System.Drawing.Point(387, 183);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(76, 13);
               this.label8.TabIndex = 22;
               this.label8.Text = "Reaction Time";
               // 
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.Location = new System.Drawing.Point(64, 218);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(61, 13);
               this.label9.TabIndex = 23;
               this.label9.Text = "Brake Rate";
               // 
               // label10
               // 
               this.label10.AutoSize = true;
               this.label10.Location = new System.Drawing.Point(387, 218);
               this.label10.Name = "label10";
               this.label10.Size = new System.Drawing.Size(98, 13);
               this.label10.TabIndex = 24;
               this.label10.Text = "Runway Accel Sec";
               // 
               // label11
               // 
               this.label11.AutoSize = true;
               this.label11.Location = new System.Drawing.Point(64, 254);
               this.label11.Name = "label11";
               this.label11.Size = new System.Drawing.Size(103, 13);
               this.label11.TabIndex = 25;
               this.label11.Text = "Propulsion Rem Sec";
               // 
               // label12
               // 
               this.label12.AutoSize = true;
               this.label12.Location = new System.Drawing.Point(388, 254);
               this.label12.Name = "label12";
               this.label12.Size = new System.Drawing.Size(100, 13);
               this.label12.TabIndex = 26;
               this.label12.Text = "Brake Build Up Sec";
               // 
               // label13
               // 
               this.label13.AutoSize = true;
               this.label13.Location = new System.Drawing.Point(64, 289);
               this.label13.Name = "label13";
               this.label13.Size = new System.Drawing.Size(99, 13);
               this.label13.TabIndex = 27;
               this.label13.Text = "Overhang Distance";
               // 
               // label14
               // 
               this.label14.AutoSize = true;
               this.label14.Location = new System.Drawing.Point(64, 45);
               this.label14.Name = "label14";
               this.label14.Size = new System.Drawing.Size(49, 13);
               this.label14.TabIndex = 28;
               this.label14.Text = "Direction";
               // 
               // label15
               // 
               this.label15.AutoSize = true;
               this.label15.Location = new System.Drawing.Point(387, 45);
               this.label15.Name = "label15";
               this.label15.Size = new System.Drawing.Size(34, 13);
               this.label15.TabIndex = 29;
               this.label15.Text = "Move";
               // 
               // MoveBox
               // 
               this.MoveBox.Location = new System.Drawing.Point(517, 45);
               this.MoveBox.Name = "MoveBox";
               this.MoveBox.Size = new System.Drawing.Size(100, 20);
               this.MoveBox.TabIndex = 30;
               // 
               // DirectionBox
               // 
               this.DirectionBox.Location = new System.Drawing.Point(187, 42);
               this.DirectionBox.Name = "DirectionBox";
               this.DirectionBox.Size = new System.Drawing.Size(100, 20);
               this.DirectionBox.TabIndex = 31;
               // 
               // AddNewTrackForm
               // 
               this.AcceptButton = this.button2;
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.CancelButton = this.button1;
               this.ClientSize = new System.Drawing.Size(648, 382);
               this.Controls.Add(this.DirectionBox);
               this.Controls.Add(this.MoveBox);
               this.Controls.Add(this.label15);
               this.Controls.Add(this.label14);
               this.Controls.Add(this.label13);
               this.Controls.Add(this.label12);
               this.Controls.Add(this.label11);
               this.Controls.Add(this.label10);
               this.Controls.Add(this.label9);
               this.Controls.Add(this.label8);
               this.Controls.Add(this.label7);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.OverhangDistanceBox);
               this.Controls.Add(this.BrakeBuildUpSecBox);
               this.Controls.Add(this.PropulsionRemSecBox);
               this.Controls.Add(this.RunwayAcelSecBox);
               this.Controls.Add(this.BrakeRateBox);
               this.Controls.Add(this.ReactionTimeBox);
               this.Controls.Add(this.VehicleAccelBox);
               this.Controls.Add(this.OverSpeedBox);
               this.Controls.Add(this.SpeedMaxBox);
               this.Controls.Add(this.GradeWorstBox);
               this.Controls.Add(this.TargetLocationBox);
               this.Controls.Add(this.BrakeLocationBox);
               this.Controls.Add(this.TrackCircuitBox);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.button1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
               this.MaximizeBox = false;
               this.MinimizeBox = false;
               this.Name = "AddNewTrackForm";
               this.ShowIcon = false;
               this.Text = "Add Track Segment";
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TrackCircuitBox;
        private System.Windows.Forms.TextBox BrakeLocationBox;
        private System.Windows.Forms.TextBox TargetLocationBox;
        private System.Windows.Forms.TextBox GradeWorstBox;
        private System.Windows.Forms.TextBox SpeedMaxBox;
        private System.Windows.Forms.TextBox OverSpeedBox;
        private System.Windows.Forms.TextBox VehicleAccelBox;
        private System.Windows.Forms.TextBox ReactionTimeBox;
        private System.Windows.Forms.TextBox BrakeRateBox;
        private System.Windows.Forms.TextBox RunwayAcelSecBox;
        private System.Windows.Forms.TextBox PropulsionRemSecBox;
        private System.Windows.Forms.TextBox BrakeBuildUpSecBox;
        private System.Windows.Forms.TextBox OverhangDistanceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox MoveBox;
        private System.Windows.Forms.TextBox DirectionBox;
    }
}