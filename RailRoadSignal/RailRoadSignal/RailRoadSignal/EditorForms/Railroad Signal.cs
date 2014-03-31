using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using RailRoadSignal.Files;


namespace RailRoadSignal.EditorForms
{
    public partial class Railroad_Signal : Form
    {
        private TrackViewDisplay trackViewDisplay;
        private DataViewForm dataViewForm;
        private MainMenuForm mainMenu;


        public bool createNewTrack;

        /// <summary>
        /// Initialize all the componenets for the application
        /// </summary>
        public Railroad_Signal()
        {
            InitializeComponent();



            // Set up a new track view, 
            // but don't make it visible
            trackViewDisplay = new TrackViewDisplay();
            trackViewDisplay.MdiParent = this;
            trackViewDisplay.WindowState = FormWindowState.Maximized;
            trackViewDisplay.Show();
            trackViewDisplay.Visible = false;

            // Set up a new data view,
            // but don't make it visible
            dataViewForm = new DataViewForm();
            dataViewForm.MdiParent = this;
            dataViewForm.WindowState = FormWindowState.Maximized;
            dataViewForm.Show();
            dataViewForm.Visible = false;
            UpdateTrackInformation();

            //Start the program at the main menu
            mainMenu = new MainMenuForm();
            mainMenu.MdiParent = this;
            mainMenu.WindowState = FormWindowState.Maximized;
            mainMenu.Show();
            mainMenu.Visible = true;
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
        /// Make the Track viw visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (trackViewDisplay != null)
            {

                trackViewDisplay.WindowState = FormWindowState.Maximized;
                trackViewDisplay.Visible = true;
                dataViewForm.Visible = false;
                mainMenu.Visible = false;

            }

        }

        /// <summary>
        /// Make the data view visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // make the data view visible
            SetDataView();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // doesnt do anything now
            // There are multiple other options.
        }

        /// <summary>
        /// Opens the Save dialog box
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
                // refreshes the dataview to the new list of track segments
                dataViewForm.UpdateDataView();
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


            if (trackSegmentForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                /// <param name="trackID"></param>
                /// <param name="startPoint"></param>
                /// <param name="endPoint"></param>
                /// <param name="brakeLocation"></param>
                /// <param name="targetLocation"></param>
                /// <param name="gradeWorst"></param>
                /// <param name="speedMax"></param>
                /// <param name="overspeed"></param>
                /// <param name="vehicleAccel"></param>
                /// <param name="reactionTime"></param>
                /// <param name="brakeRate"></param>
                /// <param name="runwayAccelSec"></param>
                /// <param name="propulsionRemSec"></param>
                /// <param name="brakeBuildUpSec"></param>
                /// <param name="overhangDist"></param>
                /// <param name="safetyFact"></param>
                TrackLayout.Track.Add(new TrackSegment(trackSegmentForm.trackIDBox.Text,
                        "", "", "",
                        new Vector2((float)Convert.ToDouble(trackSegmentForm.startPositionXBox.Text),
                        (float)Convert.ToDouble(trackSegmentForm.startPositionYBox.Text)),
                        new Vector2((float)Convert.ToDouble(trackSegmentForm.endPositionXBox.Text),
                        (float)Convert.ToDouble(trackSegmentForm.endPositionYBox.Text)),
                        Convert.ToInt32(trackSegmentForm.BrakeLocationBox.Text),
                        Convert.ToInt32(trackSegmentForm.TargetLocationBox.Text),
                        Convert.ToDouble(trackSegmentForm.GradeWorstBox.Text),
                        Convert.ToDouble(trackSegmentForm.SpeedMaxBox.Text),
                        Convert.ToDouble(trackSegmentForm.OverSpeedBox.Text),
                        Convert.ToDouble(trackSegmentForm.VehicleAccelBox.Text),
                        Convert.ToDouble(trackSegmentForm.ReactionTimeBox.Text),
                        Convert.ToDouble(trackSegmentForm.BrakeRateBox.Text),
                        Convert.ToDouble(trackSegmentForm.RunwayAccelSecBox.Text),
                        Convert.ToDouble(trackSegmentForm.PropulsionRemSecBox.Text),
                        Convert.ToInt32(trackSegmentForm.BrakeBuildUpSecBox.Text),
                        Convert.ToInt32(trackSegmentForm.OverhangDistBox.Text),
                        Convert.ToDouble(trackSegmentForm.SafetyFactBox.Text)));

                dataViewForm.UpdateDataView();

            }
        }

        /// <summary>
        ///  This is sample data for a basic track layout
        /// </summary>
        private void LoadSampleTrack()
        {
            /*
            TrackLayout.Track.Add(new TrackSegment("921T", new Vector2(-1100, 100), new Vector2(300, 100), 48895, 49485, 1.296, 15.0, 1.0, 2.31, 4.8, 1.67, 1.2, 0.5, 1, 28, 0));
            TrackLayout.Track.Add(new TrackSegment("921T", new Vector2(300, 100), new Vector2(400, 0), 48895, 50100, 2.467, 35.0, 2.0, 1.6007, 4.8, 1.67, 1.2, 0.5, 1, 28, 0));
            TrackLayout.Track.Add(new TrackSegment("931T", new Vector2(400, 0), new Vector2(700, 0), 49485, 50100, 3.59, 20.0, 1.0, 2.31, 4.8, 1.67, 1.2, 0.5, 1, 28, 0));
            TrackLayout.Track.Add(new TrackSegment("931T", new Vector2(700, 0), new Vector2(800, 100), 49485, 51066, 1.879, 45.0, 2.0, 1.0565, 4.8, 1.67, 1.2, 0.5, 1, 28, 0));
            TrackLayout.Track.Add(new TrackSegment("931T", new Vector2(300, 100), new Vector2(800, 100), 49485, 52032, -0.405, 55.0, 2.0, 0.6079, 4.8, 1.67, 1.2, 0.5, 1, 28, 0));
            TrackLayout.Track.Add(new TrackSegment("951T", new Vector2(800, 100), new Vector2(1100, 100), 50100, 51066, 0.7902, 25.0, 2.0, 2.2406, 4.8, 1.67, 1.2, 0.5, 1, 28, 0));
            TrackLayout.Track.Add(new TrackSegment("951T", new Vector2(-100, 120), new Vector2(300, 120), 50100, 52032, -1.677, 35.0, 2.0, 1.6007, 4.8, 1.67, 1.2, 0.5, 1, 28, 0));
            TrackLayout.Track.Add(new TrackSegment("951T", new Vector2(300, 120), new Vector2(1100, 120), 50100, 52998, -0.962, 55.0, 2.0, 0.6079, 4.8, 1.67, 1.2, 0.5, 1, 28, 0));
            TrackLayout.Track.Add(new TrackSegment("961T", new Vector2(-100, 120), new Vector2(-200, 220), 50166, 52998, -1.837, 35.0, 2.0, 1.6007, 4.8, 1.67, 1.2, 0.5, 1, 28, 0));
            TrackLayout.Track.Add(new TrackSegment("961T", new Vector2(-200, 220), new Vector2(-500, 220), 50166, 53964, -2.032, 45.0, 2.0, 1.0565, 4.8, 1.67, 1.2, 0.5, 1, 28, 0));
            TrackLayout.Track.Add(new TrackSegment("961T", new Vector2(-500, 220), new Vector2(-600, 120), 50166, 54930, -0.819, 65.0, 2.0, .3471, 4.8, 1.67, 1.2, 0.5, 1, 28, 0));
            dataViewForm.UpdateDataView();
             * */
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // example files

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
        private void trackInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrackInformationForm infoForm = new TrackInformationForm();
            infoForm.CustomerBox.Text = TrackLayout.Customer;
            infoForm.ProjectNameBox.Text = TrackLayout.ProjectName;
            infoForm.ContractBox.Text = TrackLayout.Contract;
            infoForm.PreparerBox.Text = TrackLayout.Preparer;
            infoForm.MaxSpeedBox.Text = TrackLayout.MaxSpeed.ToString();
            infoForm.TypeBox.Text = TrackLayout.TrainType;
            infoForm.TonnageBox.Text = TrackLayout.Tonnage.ToString();
            infoForm.MaxLengthBox.Text = TrackLayout.MaxBlockLength.ToString();
            infoForm.BreakingCharacteristicsBox.Text = TrackLayout.BreakingCharacteristics;
            if (TrackLayout.Miles == true)
            {
                infoForm.PostRangeBox.Text = "Miles";

            }
            else
            {
                infoForm.PostRangeBox.Text = "Kilometers";

            }


            infoForm.ShowDialog(this);

        }

        public void UpdateTrackInformation()
        {
            dataViewForm.CustomerBox.Text = TrackLayout.Customer;
            dataViewForm.ProjectNameBox.Text = TrackLayout.ProjectName;
            dataViewForm.MaxSpeedBox.Text = TrackLayout.MaxSpeed.ToString();
            dataViewForm.TypeBox.Text = TrackLayout.TrainType;
            dataViewForm.TonnageBox.Text = TrackLayout.Tonnage.ToString();
            dataViewForm.MaxBlockLengthBox.Text = TrackLayout.MaxBlockLength.ToString();
            dataViewForm.BreakingCharBox.Text = TrackLayout.BreakingCharacteristics;
            if (TrackLayout.Miles == true)
            {

                dataViewForm.PostRangeBox.Text = "Miles";
            }
            else
            {

                dataViewForm.PostRangeBox.Text = "Kilometers";
            }

            dataViewForm.Refresh();
        }
        /// <summary>
        /// About Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            if (about.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                about.Close();
            }

        }

        /// <summary>
        /// Load from database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fromDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Start a new track layout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void SetDataView()
        {
            if (dataViewForm != null)
            {

                UpdateTrackInformation();
                dataViewForm.UpdateDataView();
                dataViewForm.WindowState = FormWindowState.Maximized;
                dataViewForm.Visible = true;
                mainMenu.Visible = false;
                dataViewForm.Refresh();
            }
        }
        /// <summary>
        /// A test set of data to display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadSampleDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadSampleTrack();
        }

    }
}
