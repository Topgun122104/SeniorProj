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
                    string id;
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

                         if(row[1] != "")
                         {
                              id = row[1];
                         }

                        /* 
                         * Column Name      |   Column Number
                         * Track            |         1
                         * Direction        |         2
                         * Move             |         3
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
                        TrackSegment curRow = new TrackSegment(id,
                                                    row[2] != "" ? row[2] : (sheet.getRow(sheet.getCurrentRow() - 1)).Direction,                 // Direction
                                                    row[3] != "" ? row[3] : (sheet.getRow(sheet.getCurrentRow() - 1)).MoveNormRevDiv,            // Move
                                                    row[4],                                             // Circuit                                             
                                                    Convert.ToInt32(row[5]),                            // Brake Location
                                                    Convert.ToInt32(row[6]),                            // Target Location
                                                    Convert.ToDouble(row[8]),                           // Worst Grade
                                                    Convert.ToDouble(row[9]),                           // Entry Speed
                                                    Convert.ToDouble(row[10]),                          // Overspeed
                                                    Convert.ToDouble(row[12]),                          // Acceleration
                                                    Convert.ToDouble(row[14]),                          // Reaction Time
                                                    Convert.ToDouble(row[16]),                          // Brake Rate
                                                    Convert.ToDouble(row[19]),                          // Runaway Accel
                                                    Convert.ToDouble(row[21]),                          // Propulsion Removal
                                                    Convert.ToInt32(row[23]),                           // Brake Build Up
                                                    Convert.ToInt32(row[25]));                          // Overhand Distance


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
