using Signal_Block_Design_Tool.Forms;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;



namespace Signal_Block_Design_Tool.Files
{
    public class ExcelParser
    {
        string mFilename;

        /// <summary>
        /// Excel Parser Constructor
        /// </summary>
        /// <param name="filename"></param>
        public ExcelParser(string filename)
        {
            mFilename = filename;
        }

        /// <summary>
        /// 
        /// </summary>
        public void processData()
        {
            FillTrack();
        }

        /// <summary>
        /// 
        /// </summary>
        public void cleanUp()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="worksheet"></param>
        public void FillTrack()
        {
            ProgressBoxForm progressBox = new ProgressBoxForm();
            progressBox.Show();
            try
            {

                ExcelSheet sheet = new ExcelSheet();
                using (StreamReader file = new StreamReader(mFilename))
                {
                    string line = null;
                    string[] row;
                    string tempDir = null;
                    string tempMove = null;
                    // Get to the data
                    while (line == null || line.Split(',')[1] != "Track")
                    {
                        line = file.ReadLine();
                    }
                    
                    // Parse the data
                    while ((line = file.ReadLine()) != null)
                    {  
                        row = line.Split(',');
                        // If this cell does not have data then there is no more data.
                        if (row[4] == "")
                        {
                            break;
                        }

                        if (row[2] != "")
                        {
                             tempDir = row[2];
                        }

                         if(row[3] != "")
                         {
                              tempMove = row[3];
                         }

                        /* 
                         * Column Name      |   Column Number
                         * Direction        |         1
                         * Move             |         2
                         * Track            |         3
                         * Circuit          |         4
                         * Brake Location   |         5
                         * Target Location  |         6
                         * Worst Grade      |         8
                         * Entry Speed      |         9
                         * Overspeed        |         10
                         * Acceleration     |         12
                         * Reaction Time    |         14
                         * Brake Rate       |         16
                         * Runaway Accel    |         19
                         * Propulsion Remov |         21
                         * Brake Build up   |         23
                         * Overhang Dist    |         25
                         */
                        TrackSegment curRow = new TrackSegment( 
                                                    tempDir,
                                                    tempMove,           
                                                    row[4],                                             // Circuit                                             
                                                    Convert.ToInt32(row[5]),                            // Brake Location
                                                    Convert.ToInt32(row[6]),                            // Target Location
                                                    Convert.ToDouble(row[7]),                           // Worst Grade
                                                    Convert.ToDouble(row[8]),                           // Entry Speed
                                                    Convert.ToDouble(row[9]),                          // Overspeed
                                                    Convert.ToDouble(row[10]),                          // Acceleration
                                                    Convert.ToDouble(row[11]),                          // Reaction Time
                                                    Convert.ToDouble(row[12]),                          // Brake Rate
                                                    Convert.ToDouble(row[13]),                          // Runaway Accel
                                                    Convert.ToDouble(row[14]),                          // Propulsion Removal
                                                    Convert.ToInt32(row[15]),                           // Brake Build Up
                                                    Convert.ToInt32(row[16]));                          // Overhand Distance


                        TrackLayout.Track.Add(curRow);
                        progressBox.progressBar1.PerformStep();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Loading File: " + e.ToString());
            }

            progressBox.Close();

        }
    }
}
