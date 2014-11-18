using System.Windows.Forms;
using Signal_Block_Design_Tool.Files;

namespace Signal_Block_Design_Tool.Forms
{
    public partial class SignalBlockForm : Form
    {
        private MainMenuForm mainMenuForm;
        private TrackViewForm trackViewForm;
        private DataViewForm dataViewForm;


        private StatusBar statusBar = new StatusBar();
        private StatusBarPanel panel2 = new StatusBarPanel();

        public SignalBlockForm()
        {
            InitializeComponent();

            mainMenuForm = new MainMenuForm();
            mainMenuForm.MdiParent = this;
            mainMenuForm.WindowState = FormWindowState.Maximized;
            mainMenuForm.Show();
            mainMenuForm.Visible = true;

            trackViewForm = new TrackViewForm();
            trackViewForm.MdiParent = this;
            trackViewForm.WindowState = FormWindowState.Maximized;
            trackViewForm.Show();
            trackViewForm.Visible = false;

            dataViewForm = new DataViewForm();
            dataViewForm.MdiParent = this;
            dataViewForm.WindowState = FormWindowState.Maximized;

            dataViewForm.Show();
            dataViewForm.Visible = false;

            panel2.ToolTipText = "Started: " + System.DateTime.Now.ToShortTimeString();
            panel2.Text = System.DateTime.Today.ToLongDateString();
            panel2.AutoSize = StatusBarPanelAutoSize.Contents;
            statusBar.ShowPanels = true;
            statusBar.Panels.Add(panel2);
            this.Controls.Add(statusBar);

        }

        private void dataToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            dataViewForm.UpdateDataView();
            dataViewForm.UpdateTreeView();
            mainMenuForm.Visible = false;
            trackViewForm.Visible = false;
            dataViewForm.WindowState = FormWindowState.Maximized;
            dataViewForm.Visible = true;
        }

        private void trackLayoutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mainMenuForm.Visible = false;
            dataViewForm.Visible = false;
            trackViewForm.WindowState = FormWindowState.Maximized;
            trackViewForm.Visible = true;
        }

        private void trackInfoToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            File.CreateNewTrack();
        }

        private void loadToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            File.LoadTrack();
        }

        private void importToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            File.SaveTrack();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Topgun122104/SeniorProj/wiki");
        }

        private void aboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog(this);
        }

        private void newTrackToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AddNewTrackForm trackForm = new AddNewTrackForm();
            if ((trackForm.ShowDialog(this)) == System.Windows.Forms.DialogResult.OK)
            {
                //TrackLayout.Track.Add(new TrackSegment(tra)
            }

        }

        private void fromFileToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            File.ImportFromFile();
        }

        private void fromDatabaseToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            File.LoadFromDatabase();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mainMenuForm.Visible = true;
            dataViewForm.Visible = false;
            trackViewForm.Visible = false;
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }



    }
}
