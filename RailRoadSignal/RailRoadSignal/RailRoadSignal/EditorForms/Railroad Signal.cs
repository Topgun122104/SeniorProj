using System;
using System.IO;
using System.Windows.Forms;


namespace RailRoadSignal.EditorForms
{
    public partial class Railroad_Signal : Form
    {
        private TrackViewDisplay trackViewDisplay;
        private DataViewForm dataViewForm;
        private MainMenuForm mainMenu;


        /// <summary>
        /// Initialize all the componenets for the application
        /// </summary>
        public Railroad_Signal()
        {
            InitializeComponent();

            mainMenu = new MainMenuForm();
            mainMenu.MdiParent = this;
            mainMenu.WindowState = FormWindowState.Maximized;
            mainMenu.Show();
            mainMenu.Visible = true;

            trackViewDisplay = new TrackViewDisplay();
            trackViewDisplay.MdiParent = this;
            trackViewDisplay.WindowState = FormWindowState.Maximized;
            trackViewDisplay.Show();
            trackViewDisplay.Visible = false;

            dataViewForm = new DataViewForm();
            dataViewForm.MdiParent = this;
            dataViewForm.WindowState = FormWindowState.Maximized;
            dataViewForm.Show();
            dataViewForm.Visible = false;
        }


        /// <summary>
        /// Exit the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (trackViewDisplay != null)
            {

                trackViewDisplay.Visible = true;
                dataViewForm.Visible = false;
                mainMenu.Visible = false;

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // make the data view visible
            if (dataViewForm != null)
            {
                dataViewForm.Visible = true;
                //trackViewDisplay.Visible = false;
                mainMenu.Visible = false;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // example files
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // example files
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        }

        /// <summary>
        /// Opens a NewTrackForm window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTrackSegmentForm trackSegmentForm = new NewTrackSegmentForm();
            trackSegmentForm.ShowDialog();
        }

    }
}
