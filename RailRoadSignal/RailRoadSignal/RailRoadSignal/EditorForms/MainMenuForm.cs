using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using RailRoadSignal.Files;
using RailRoadSignal.Database;
using System.Threading;

namespace RailRoadSignal.EditorForms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  creates a new track layout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            NewTrackLayoutForm newTrackLayout = new NewTrackLayoutForm();
            if (newTrackLayout.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {


                // TODO: need to do error checking on the input to make sure that all the 
                // fields are filled out.
                // Do we do this with a bunch of if statements?

                this.Visible = false;
                TrackLayout.Customer = newTrackLayout.CustomerBox.Text;
                TrackLayout.ProjectName = newTrackLayout.ProjectNameBox.Text;
                TrackLayout.Contract = newTrackLayout.ContractBox.Text;
                TrackLayout.Preparer = newTrackLayout.PreparerBox.Text;
                TrackLayout.MaxSpeed = Convert.ToDouble(newTrackLayout.MaxSpeedBox.Text);
                TrackLayout.TrainType = newTrackLayout.TypeBox.Text;
                TrackLayout.Tonnage = Convert.ToDouble(newTrackLayout.TonnageBox.Text);
                TrackLayout.MaxBlockLength = Convert.ToDouble(newTrackLayout.MaxBlockLengthBox.Text);
                TrackLayout.BreakingCharacteristics = newTrackLayout.BreakingCharacteristicsBox.Text;

            }
        }


        /// <summary>
        /// Loads a track from a database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            // load a track from the database
            LoadFromDatabaseForm databaseForm = new LoadFromDatabaseForm();
            if (databaseForm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                // TODO: Set up the database
                Database.DatabaseConnection conn = new Database.DatabaseConnection(databaseForm.ServerNameBox.Text,
                    Convert.ToUInt32(databaseForm.PortBox.Text), databaseForm.DatabaseNameBox.Text,
                    databaseForm.UserNameBox.Text, databaseForm.PasswordBox.Text);

                Query q = new Query();
                List<string> list = q.runQuery(conn, "select * from trackSegment where trackCircuit = '921T'");
                string text = "";
                for (int i = 0; i < list.Count; i++)
                {
                    text += list[i] + "\n";
                }
                MessageBox.Show(text);
            }

        }

        /// <summary>
        /// Loads a saved Track layout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            // load a local saved track
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

        private void button4_Click(object sender, EventArgs e)
        {

            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Types of files to read
            openFileDialog.Filter = "Comma Seperated Value (*.csv)|*.csv | Excel 97-2003 (*.xls)|*.xls | Excel Workbook (*.xlsx)|*.xlsx";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            if (openFileDialog.FilterIndex == 1)
                            {

                            }
                            // if its a excel file
                            if (openFileDialog.FilterIndex == 3 || openFileDialog.FilterIndex == 2)
                            {
                                 

                                Thread t = new Thread(LoadExcelFile);
                                t.IsBackground = true;
                                t.Start(openFileDialog.FileName);
                                
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
                
            }
            // nothing yet
        }


        private void LoadExcelFile(object filename)
        {
            ExcelParser parser = new ExcelParser(filename.ToString());
            parser.processData();
            parser.cleanUp();
        }
    }
}
