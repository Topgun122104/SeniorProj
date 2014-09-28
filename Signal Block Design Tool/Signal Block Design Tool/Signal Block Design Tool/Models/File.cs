using MySql.Data.MySqlClient;
using Signal_Block_Design_Tool.Database;
using Signal_Block_Design_Tool.Forms;
using Signal_Block_Design_Tool.Misc;
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
                List<string> list;

                String p = Prompt.ShowDialog("Enter A Track Circuit\n\n Type 'ALL' to Display Every Track Circuit", "Track Information Needed!");
                p = p.ToUpper();
                if(p == "ALL")
                {
                     list = q.runQuery(conn, "select * from trackSegment");
                }
                else
                {
                    list = q.runQuery(conn, "select * from trackSegment where trackCircuit = '" + p + "'");
                }

                int numRows = list.Count / 15;
                TrackSegment ts;
                for (int i = 0; i < numRows; i++)
                {
                     ts = new TrackSegment(list[0].ToString(), Convert.ToInt32(list[2].ToString()), Convert.ToInt32(list[3].ToString()), Convert.ToDouble(list[4].ToString()), 
                          Convert.ToDouble(list[5].ToString()), Convert.ToDouble(list[6].ToString()), Convert.ToDouble(list[7].ToString()), Convert.ToDouble(list[8].ToString()),
                          Convert.ToDouble(list[9].ToString()), Convert.ToDouble(list[10].ToString()), Convert.ToDouble(list[11].ToString()), Convert.ToInt32(list[12].ToString()),
                          Convert.ToInt32(list[13].ToString()));
                     TrackLayout.Track.Add(ts);

                     for(int j = 0; j < 15; j++)
                     {
                          list.RemoveAt(0);
                     }
                }
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

                
                DatabaseConnection conn = new DatabaseConnection(
                    "andrew.cs.fit.edu",
                    3306,
                    "signalblockdesign",
                    "signalblockdesig",
                    "E2SnzbV922m6R51");
                conn.openConnection();

                foreach (TrackSegment t in TrackLayout.Track)
                {
                    DatabaseOperations.InsertIntoDatabase(conn, t);
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
