using System;
using System.Windows.Forms;
using Signal_Block_Design_Tool.Files;
using System.Drawing;

namespace Signal_Block_Design_Tool.Forms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void NewTrackButton_Click(object sender, EventArgs e)
        {
            File.CreateNewTrack();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            File.ImportFromFile();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            File.LoadTrack();
        }

        private void DatabaseButton_Click(object sender, EventArgs e)
        {
            File.LoadFromDatabase();

        }

        private void NewTrackButton_MouseLeave(object sender, EventArgs e)
        {
            this.NewTrackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(116)))), ((int)(((byte)(186)))));
        }

        private void ImportButton_MouseLeave(object sender, EventArgs e)
        {
            this.ImportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(116)))), ((int)(((byte)(186)))));
        }

        private void ContinueButton_MouseEnter(object sender, EventArgs e)
        {
            this.ContinueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(206)))));
        }

        private void ContinueButton_MouseLeave(object sender, EventArgs e)
        {
            this.ContinueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(116)))), ((int)(((byte)(186)))));
        }

        private void DatabaseButton_MouseEnter(object sender, EventArgs e)
        {
            this.DatabaseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(206)))));
        }

        private void DatabaseButton_MouseLeave(object sender, EventArgs e)
        {
            this.DatabaseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(116)))), ((int)(((byte)(186)))));
        }

        private void NewTrackButton_MouseEnter(object sender, EventArgs e)
        {
            this.NewTrackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(206)))));
        }

        private void ImportButton_MouseEnter(object sender, EventArgs e)
        {
            this.ImportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(206)))));
        }

        private void ClearDataBase_Click(object sender, EventArgs e)
        {
             File.ClearDataBase();
        }

        private void ClearDataBase_MouseEnter(object sender, EventArgs e)
        {
             this.ClearDataBaseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(130)))), ((int)(((byte)(206)))));
        }
        private void ClearDataBase_MouseLeave(object sender, EventArgs e)
        {
            this.ClearDataBaseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(116)))), ((int)(((byte)(186)))));
        }
    }
}
