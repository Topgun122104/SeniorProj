namespace Signal_Block_Design_Tool.Forms
{
    partial class MainMenuForm
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
               this.Title = new System.Windows.Forms.Label();
               this.DatabaseButton = new System.Windows.Forms.Button();
               this.ContinueButton = new System.Windows.Forms.Button();
               this.ImportButton = new System.Windows.Forms.Button();
               this.NewTrackButton = new System.Windows.Forms.Button();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.ClearDataBase = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // Title
               // 
               this.Title.AutoSize = true;
               this.Title.Location = new System.Drawing.Point(588, 58);
               this.Title.Name = "Title";
               this.Title.Size = new System.Drawing.Size(629, 63);
               this.Title.TabIndex = 1;
               this.Title.Text = "Signal Block Design Tool";
               // 
               // DatabaseButton
               // 
               this.DatabaseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(116)))), ((int)(((byte)(186)))));
               this.DatabaseButton.BackgroundImage = global::Signal_Block_Design_Tool.Properties.Resources.database1;
               this.DatabaseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.DatabaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.DatabaseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.DatabaseButton.Location = new System.Drawing.Point(216, 427);
               this.DatabaseButton.Name = "DatabaseButton";
               this.DatabaseButton.Size = new System.Drawing.Size(160, 160);
               this.DatabaseButton.TabIndex = 5;
               this.DatabaseButton.Text = "Load From Database";
               this.DatabaseButton.UseVisualStyleBackColor = false;
               this.DatabaseButton.Click += new System.EventHandler(this.DatabaseButton_Click);
               this.DatabaseButton.MouseEnter += new System.EventHandler(this.DatabaseButton_MouseEnter);
               this.DatabaseButton.MouseLeave += new System.EventHandler(this.DatabaseButton_MouseLeave);
               // 
               // ContinueButton
               // 
               this.ContinueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(116)))), ((int)(((byte)(186)))));
               this.ContinueButton.BackgroundImage = global::Signal_Block_Design_Tool.Properties.Resources.load;
               this.ContinueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.ContinueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.ContinueButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.ContinueButton.Location = new System.Drawing.Point(41, 427);
               this.ContinueButton.Name = "ContinueButton";
               this.ContinueButton.Size = new System.Drawing.Size(160, 160);
               this.ContinueButton.TabIndex = 4;
               this.ContinueButton.Text = "Continue a Previous Track";
               this.ContinueButton.UseVisualStyleBackColor = false;
               this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
               this.ContinueButton.MouseEnter += new System.EventHandler(this.ContinueButton_MouseEnter);
               this.ContinueButton.MouseLeave += new System.EventHandler(this.ContinueButton_MouseLeave);
               // 
               // ImportButton
               // 
               this.ImportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(116)))), ((int)(((byte)(186)))));
               this.ImportButton.BackgroundImage = global::Signal_Block_Design_Tool.Properties.Resources.import;
               this.ImportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.ImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.ImportButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.ImportButton.Location = new System.Drawing.Point(216, 249);
               this.ImportButton.Name = "ImportButton";
               this.ImportButton.Size = new System.Drawing.Size(160, 160);
               this.ImportButton.TabIndex = 3;
               this.ImportButton.Text = "Import From File";
               this.ImportButton.UseVisualStyleBackColor = false;
               this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
               this.ImportButton.MouseEnter += new System.EventHandler(this.ImportButton_MouseEnter);
               this.ImportButton.MouseLeave += new System.EventHandler(this.ImportButton_MouseLeave);
               // 
               // NewTrackButton
               // 
               this.NewTrackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(116)))), ((int)(((byte)(186)))));
               this.NewTrackButton.BackgroundImage = global::Signal_Block_Design_Tool.Properties.Resources._new;
               this.NewTrackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.NewTrackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.NewTrackButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.NewTrackButton.Location = new System.Drawing.Point(41, 249);
               this.NewTrackButton.Name = "NewTrackButton";
               this.NewTrackButton.Size = new System.Drawing.Size(160, 160);
               this.NewTrackButton.TabIndex = 2;
               this.NewTrackButton.Text = "Create New Track Layout";
               this.NewTrackButton.UseVisualStyleBackColor = false;
               this.NewTrackButton.Click += new System.EventHandler(this.NewTrackButton_Click);
               this.NewTrackButton.MouseEnter += new System.EventHandler(this.NewTrackButton_MouseEnter);
               this.NewTrackButton.MouseLeave += new System.EventHandler(this.NewTrackButton_MouseLeave);
               // 
               // pictureBox1
               // 
               this.pictureBox1.Image = global::Signal_Block_Design_Tool.Properties.Resources.GE_TRansportation_Logo;
               this.pictureBox1.Location = new System.Drawing.Point(41, 58);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(500, 147);
               this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox1.TabIndex = 0;
               this.pictureBox1.TabStop = false;
               // 
               // button1
               // 
               this.ClearDataBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(116)))), ((int)(((byte)(186)))));
               this.ClearDataBase.BackgroundImage = global::Signal_Block_Design_Tool.Properties.Resources.database1;
               this.ClearDataBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.ClearDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.ClearDataBase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
               this.ClearDataBase.Location = new System.Drawing.Point(397, 249);
               this.ClearDataBase.Name = "ClearDataBase";
               this.ClearDataBase.Size = new System.Drawing.Size(160, 160);
               this.ClearDataBase.TabIndex = 6;
               this.ClearDataBase.Text = "Clear Database";
               this.ClearDataBase.UseVisualStyleBackColor = false;
               this.ClearDataBase.Click += new System.EventHandler(this.ClearDataBase_Click);
               // 
               // MainMenuForm
               // 
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
               this.ClientSize = new System.Drawing.Size(1280, 650);
               this.ControlBox = false;
               this.Controls.Add(this.ClearDataBase);
               this.Controls.Add(this.DatabaseButton);
               this.Controls.Add(this.ContinueButton);
               this.Controls.Add(this.ImportButton);
               this.Controls.Add(this.NewTrackButton);
               this.Controls.Add(this.Title);
               this.Controls.Add(this.pictureBox1);
               this.DoubleBuffered = true;
               this.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(116)))), ((int)(((byte)(186)))));
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "MainMenuForm";
               this.ShowInTaskbar = false;
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
               this.Text = "MainMenuForm";
               this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button NewTrackButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Button DatabaseButton;
        private System.Windows.Forms.Button ClearDataBase;
    }
}