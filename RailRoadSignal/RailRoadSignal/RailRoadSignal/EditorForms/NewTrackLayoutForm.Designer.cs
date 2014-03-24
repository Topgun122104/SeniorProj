namespace RailRoadSignal.EditorForms
{
    partial class NewTrackLayoutForm
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
            this.CustomerBox = new System.Windows.Forms.TextBox();
            this.ProjectNameBox = new System.Windows.Forms.TextBox();
            this.ContractBox = new System.Windows.Forms.TextBox();
            this.PostRangeBox = new System.Windows.Forms.TextBox();
            this.PreparerBox = new System.Windows.Forms.TextBox();
            this.MaxSpeedBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.TonnageBox = new System.Windows.Forms.TextBox();
            this.MaxBlockLengthBox = new System.Windows.Forms.TextBox();
            this.BreakingCharacteristicsBox = new System.Windows.Forms.TextBox();
            this.KilometersCheckBox = new System.Windows.Forms.CheckBox();
            this.MilesCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(541, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Accept";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(13, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CustomerBox
            // 
            this.CustomerBox.Location = new System.Drawing.Point(110, 68);
            this.CustomerBox.Name = "CustomerBox";
            this.CustomerBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerBox.TabIndex = 2;
            // 
            // ProjectNameBox
            // 
            this.ProjectNameBox.Location = new System.Drawing.Point(378, 68);
            this.ProjectNameBox.Name = "ProjectNameBox";
            this.ProjectNameBox.Size = new System.Drawing.Size(100, 20);
            this.ProjectNameBox.TabIndex = 3;
            // 
            // ContractBox
            // 
            this.ContractBox.Location = new System.Drawing.Point(110, 123);
            this.ContractBox.Name = "ContractBox";
            this.ContractBox.Size = new System.Drawing.Size(100, 20);
            this.ContractBox.TabIndex = 4;
            // 
            // PostRangeBox
            // 
            this.PostRangeBox.Location = new System.Drawing.Point(376, 123);
            this.PostRangeBox.Name = "PostRangeBox";
            this.PostRangeBox.Size = new System.Drawing.Size(100, 20);
            this.PostRangeBox.TabIndex = 5;
            // 
            // PreparerBox
            // 
            this.PreparerBox.Location = new System.Drawing.Point(110, 178);
            this.PreparerBox.Name = "PreparerBox";
            this.PreparerBox.Size = new System.Drawing.Size(100, 20);
            this.PreparerBox.TabIndex = 6;
            // 
            // MaxSpeedBox
            // 
            this.MaxSpeedBox.Location = new System.Drawing.Point(378, 187);
            this.MaxSpeedBox.Name = "MaxSpeedBox";
            this.MaxSpeedBox.Size = new System.Drawing.Size(100, 20);
            this.MaxSpeedBox.TabIndex = 7;
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(110, 240);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(100, 20);
            this.TypeBox.TabIndex = 8;
            // 
            // TonnageBox
            // 
            this.TonnageBox.Location = new System.Drawing.Point(378, 240);
            this.TonnageBox.Name = "TonnageBox";
            this.TonnageBox.Size = new System.Drawing.Size(100, 20);
            this.TonnageBox.TabIndex = 9;
            // 
            // MaxBlockLengthBox
            // 
            this.MaxBlockLengthBox.Location = new System.Drawing.Point(166, 278);
            this.MaxBlockLengthBox.Name = "MaxBlockLengthBox";
            this.MaxBlockLengthBox.Size = new System.Drawing.Size(100, 20);
            this.MaxBlockLengthBox.TabIndex = 10;
            // 
            // BreakingCharacteristicsBox
            // 
            this.BreakingCharacteristicsBox.Location = new System.Drawing.Point(378, 278);
            this.BreakingCharacteristicsBox.Name = "BreakingCharacteristicsBox";
            this.BreakingCharacteristicsBox.Size = new System.Drawing.Size(100, 20);
            this.BreakingCharacteristicsBox.TabIndex = 11;
            // 
            // KilometersCheckBox
            // 
            this.KilometersCheckBox.AutoSize = true;
            this.KilometersCheckBox.Location = new System.Drawing.Point(525, 70);
            this.KilometersCheckBox.Name = "KilometersCheckBox";
            this.KilometersCheckBox.Size = new System.Drawing.Size(74, 17);
            this.KilometersCheckBox.TabIndex = 14;
            this.KilometersCheckBox.Text = "Kilometers";
            this.KilometersCheckBox.UseVisualStyleBackColor = true;
            this.KilometersCheckBox.CheckedChanged += new System.EventHandler(this.KilometersCheckBox_CheckedChanged);
            // 
            // MilesCheckBox
            // 
            this.MilesCheckBox.AutoSize = true;
            this.MilesCheckBox.Location = new System.Drawing.Point(525, 112);
            this.MilesCheckBox.Name = "MilesCheckBox";
            this.MilesCheckBox.Size = new System.Drawing.Size(50, 17);
            this.MilesCheckBox.TabIndex = 15;
            this.MilesCheckBox.Text = "Miles";
            this.MilesCheckBox.UseVisualStyleBackColor = true;
            this.MilesCheckBox.CheckedChanged += new System.EventHandler(this.MilesCheckBox_CheckedChanged);
            // 
            // NewTrackLayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 359);
            this.Controls.Add(this.MilesCheckBox);
            this.Controls.Add(this.KilometersCheckBox);
            this.Controls.Add(this.BreakingCharacteristicsBox);
            this.Controls.Add(this.MaxBlockLengthBox);
            this.Controls.Add(this.TonnageBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.MaxSpeedBox);
            this.Controls.Add(this.PreparerBox);
            this.Controls.Add(this.PostRangeBox);
            this.Controls.Add(this.ContractBox);
            this.Controls.Add(this.ProjectNameBox);
            this.Controls.Add(this.CustomerBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewTrackLayoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Track Layout Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox CustomerBox;
        public System.Windows.Forms.TextBox ProjectNameBox;
        public System.Windows.Forms.TextBox ContractBox;
        public System.Windows.Forms.TextBox PostRangeBox;
        public System.Windows.Forms.TextBox PreparerBox;
        public System.Windows.Forms.TextBox MaxSpeedBox;
        public System.Windows.Forms.TextBox TypeBox;
        public System.Windows.Forms.TextBox TonnageBox;
        public System.Windows.Forms.TextBox MaxBlockLengthBox;
        public System.Windows.Forms.TextBox BreakingCharacteristicsBox;
        public System.Windows.Forms.CheckBox KilometersCheckBox;
        public System.Windows.Forms.CheckBox MilesCheckBox;
    }
}