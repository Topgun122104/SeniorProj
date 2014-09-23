using MySql.Data.MySqlClient;
using Signal_Block_Design_Tool.Database;
using Signal_Block_Design_Tool.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Signal_Block_Design_Tool.Files
{
    class File
    {
        /// <summary>
        /// 
        /// </summary>
        public static void ImportFromFile()
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Types of files to read
            openFileDialog.Filter = "csv file (*.csv)|*.csv";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // if importing csv file
                            //if (openFileDialog.FilterIndex == 1)
                            //{

                            //}
                            // if its a excel file
                            if (openFileDialog.FilterIndex == 1 || openFileDialog.FilterIndex == 2)
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
        }


        /// <summary>
        /// 
        /// </summary>
        public static void LoadFromDatabase()
        {
            LoadFromDatabaseForm databaseForm = new LoadFromDatabaseForm();
            if (databaseForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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
        /// 
        /// </summary>
        public static void CreateNewTrack()
        {
            NewTrackLayoutForm newTrackLayout = new NewTrackLayoutForm();
            if (newTrackLayout.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                // TODO: need to do error checking on the input to make sure that all the 
                // fields are filled out.
                // Do we do this with a bunch of if statements?

                TrackLayout.Customer = newTrackLayout.ProjectNameBox.Text;
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
        /// 
        /// </summary>
        public static void LoadTrack()
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
        public static void SaveTrack()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        private static void LoadExcelFile(object filename)
        {
            ExcelParser parser = new ExcelParser(filename.ToString());
            parser.processData();
            try
            {
                ProgressBoxForm progress = new ProgressBoxForm();
                progress.Show();

                MySqlCommand cmd = new MySqlCommand();
                DatabaseConnection conn = new DatabaseConnection(
                    "andrew.cs.fit.edu",
                    3306,
                    "signalblockdesign",
                    "signalblockdesig",
                    "E2SnzbV922m6R51");
                conn.openConnection();

                foreach (TrackSegment t in TrackLayout.Track)
                {
                    DatabaseOperations.InsertIntoDatabase(conn, cmd, t);
                    progress.progressBar1.PerformStep();
                }
                progress.Close();
                conn.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not load into database. Original error: " + ex.Message);
            }
            parser.cleanUp();
        }


    }
}
