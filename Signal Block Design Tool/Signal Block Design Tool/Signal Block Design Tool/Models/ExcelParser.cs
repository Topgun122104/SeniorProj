using System;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using Signal_Block_Design_Tool.Forms;


namespace Signal_Block_Design_Tool.Files
{
    public class ExcelParser
    {
        String mFilename;
        Excel.Workbook mWorkBook;
        Excel.Application mApp;
        ExcelSheet[] safeBreakingSheets;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        public ExcelParser(String filename)
        {
            mFilename = filename;
            mApp = new Excel.Application();
            mWorkBook = mApp.Workbooks.Open(mFilename);

        }

        /// <summary>
        /// 
        /// </summary>
        public void processData()
        {
            int sheets = mWorkBook.Sheets.Count;
            int begin = findFirstOccurrence();
            if (begin == -1)
            {
                return;
            }
            safeBreakingSheets = new ExcelSheet[(mWorkBook.Sheets.Count - begin) + 1];
            for (int i = begin; i <= mWorkBook.Sheets.Count; i++)
            {
                Excel._Worksheet worksheet = mWorkBook.Sheets[i];
                if (worksheet.Name.Length >= 10 && ((worksheet.Name.Substring(0, 10) == "Southbound")
                    || worksheet.Name.Substring(0, 10) == "Northbound"))
                {
                    //safeBreakingSheets[i - begin] = getData(worksheet);

                    FillTrack(worksheet);
                    Marshal.ReleaseComObject(worksheet);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void cleanUp()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            mWorkBook.Close();
            Marshal.ReleaseComObject(mWorkBook);

            mApp.Quit();
            Marshal.ReleaseComObject(mApp);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="worksheet"></param>
        /// <returns></returns>
        public ExcelSheet getData(Excel._Worksheet worksheet)
        {

            ProgressBoxForm progressBox = new ProgressBoxForm();
            progressBox.Show();

            Excel.Range range = worksheet.UsedRange;
            int rows = range.Rows.Count;
            ExcelSheet currentSheet = new ExcelSheet(rows);
            for (int i = 7; i <= rows; i++)
            {
                /* 
                 * Column Name      |   Column Number
                 * Track            |         2
                 * Direction        |         3
                 * Move             |         4
                 * Circuit          |         5
                 * Brake Location   |         6
                 * Target Location  |         7
                 * Worst Grade      |         9
                 * Entry Speed      |         10
                 * Overspeed        |         11
                 * Acceleration     |         13
                 * Reaction Time    |         15
                 * Brake Rate       |         17
                 * Runaway Accel    |         20
                 * Propulsion Remov |         22
                 * Brake Build up   |         24
                 * Overhang Dist    |         26
                 */
                int currentRowInSheet = currentSheet.getCurrentRow();
                ExcelRow currentRow = new ExcelRow(
                     range.Cells[i, 2].Value2 != null ? Convert.ToInt32(range.Cells[i, 2].Value2) : currentSheet.getRow(currentRowInSheet - 1).TrackID,             // Track
                     range.Cells[i, 3].Value2 != null ? range.Cells[i, 3].Value2 : currentSheet.getRow(currentRowInSheet - 1).Direction,                         // Direction
                     range.Cells[i, 4].Value2 != null ? range.Cells[i, 4].Value2 : currentSheet.getRow(currentRowInSheet - 1).MoveNormRevDiv,                           // Move
                     range.Cells[i, 5].Value2,                          // Circuit
                     Convert.ToInt32(range.Cells[i, 6].Value2),         // Brake Location
                     Convert.ToInt32(range.Cells[i, 7].Value2),         // Target Location
                     Convert.ToDouble(range.Cells[i, 9].Value2),        // Worst Grade
                     Convert.ToInt32(range.Cells[i, 10].Value2),        // Entry Speed
                     Convert.ToInt32(range.Cells[i, 11].Value2),        // Overspeed
                     Convert.ToDouble(range.Cells[i, 13].Value2),       // Acceleration
                     Convert.ToDouble(range.Cells[i, 15].Value2),       // Reaction Time
                     Convert.ToDouble(range.Cells[i, 17].Value2),       // Brake Rate
                     Convert.ToDouble(range.Cells[i, 20].Value2),       // Runaway Accel
                     Convert.ToDouble(range.Cells[i, 22].Value2),       // Propulsion Removal
                     Convert.ToInt32(range.Cells[i, 24].Value2),        // Brake Build Up
                     Convert.ToInt32(range.Cells[i, 26].Value2));       // Overhand Distance
                currentSheet.addRow(currentRow);

                progressBox.progressBar1.PerformStep();

            }
            progressBox.Close();
            return currentSheet;
            // Create sheet that holds the rows (array), count of current array
            // Have sheet array here that holds calc data.
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="worksheet"></param>
        public void FillTrack(Excel._Worksheet worksheet)
        {
            ProgressBoxForm progressBox = new ProgressBoxForm();

            progressBox.Show();
            try
            {
                Excel.Range range = worksheet.UsedRange;
                int rows = range.Rows.Count;
                ExcelSheet currentSheet = new ExcelSheet(rows);
                for (int i = 7; i <= rows; i++)
                {
                    /* 
                     * Column Name      |   Column Number
                     * Track            |         2
                     * Direction        |         3
                     * Move             |         4
                     * Circuit          |         5
                     * Brake Location   |         6
                     * Target Location  |         7
                     * Worst Grade      |         9
                     * Entry Speed      |         10
                     * Overspeed        |         11
                     * Acceleration     |         13
                     * Reaction Time    |         15
                     * Brake Rate       |         17
                     * Runaway Accel    |         20
                     * Propulsion Remov |         22
                     * Brake Build up   |         24
                     * Overhang Dist    |         26
                     */
                    int currentRowInSheet = currentSheet.getCurrentRow();
                    string trackID = range.Cells[i, 2].Value2 != null ? range.Cells[i, 2].Value2.ToString() : currentSheet.getRow(currentRowInSheet - 1).TrackID.ToString();          // Track
                    string direction = range.Cells[i, 3].Value2 != null ? range.Cells[i, 3].Value2.ToString() : currentSheet.getRow(currentRowInSheet - 1).Direction.ToString();        // Direction
                    string move = range.Cells[i, 4].Value2 != null ? range.Cells[i, 4].Value2.ToString() : currentSheet.getRow(currentRowInSheet - 1).MoveNormRevDiv.ToString();   // Move
                    string circuit;
                    if (range.Cells[i, 5].Value2 != null)
                    {
                        circuit = range.Cells[i, 5].Value2.ToString();
                    }
                    else
                    {
                        break;
                    }
                    int brake = Convert.ToInt32(range.Cells[i, 6].Value2);         // Brake Location
                    int target = Convert.ToInt32(range.Cells[i, 7].Value2);         // Target Location
                    double worst = Convert.ToDouble(range.Cells[i, 9].Value2);        // Worst Grade
                    double entry = Convert.ToDouble(range.Cells[i, 10].Value2);       // Entry Speed
                    double over = Convert.ToDouble(range.Cells[i, 11].Value2);        // Overspeed
                    double accel = Convert.ToDouble(range.Cells[i, 13].Value2);       // Acceleration
                    double reaction = Convert.ToDouble(range.Cells[i, 15].Value2);       // Reaction Time
                    double brakeRate = Convert.ToDouble(range.Cells[i, 17].Value2);       // Brake Rate
                    double runaway = Convert.ToDouble(range.Cells[i, 20].Value2);       // Runaway Accel
                    double prop = Convert.ToDouble(range.Cells[i, 22].Value2);       // Propulsion Removal
                    int buildUp = Convert.ToInt32(range.Cells[i, 24].Value2);        // Brake Build Up
                    int overHead = Convert.ToInt32(range.Cells[i, 26].Value2);        // Overhand Distance
                    TrackLayout.Track.Add(new TrackSegment());

                    ExcelRow currentRow = new ExcelRow(
                     range.Cells[i, 2].Value2 != null ? Convert.ToInt32(range.Cells[i, 2].Value2) : currentSheet.getRow(currentRowInSheet - 1).TrackID,             // Track
                     range.Cells[i, 3].Value2 != null ? range.Cells[i, 3].Value2 : currentSheet.getRow(currentRowInSheet - 1).Direction,                         // Direction
                     range.Cells[i, 4].Value2 != null ? range.Cells[i, 4].Value2 : currentSheet.getRow(currentRowInSheet - 1).MoveNormRevDiv,                           // Move
                     range.Cells[i, 5].Value2,                          // Circuit
                     Convert.ToInt32(range.Cells[i, 6].Value2),         // Brake Location
                     Convert.ToInt32(range.Cells[i, 7].Value2),         // Target Location
                     Convert.ToDouble(range.Cells[i, 9].Value2),        // Worst Grade
                     Convert.ToInt32(range.Cells[i, 10].Value2),        // Entry Speed
                     Convert.ToInt32(range.Cells[i, 11].Value2),        // Overspeed
                     Convert.ToDouble(range.Cells[i, 13].Value2),       // Acceleration
                     Convert.ToDouble(range.Cells[i, 15].Value2),       // Reaction Time
                     Convert.ToDouble(range.Cells[i, 17].Value2),       // Brake Rate
                     Convert.ToDouble(range.Cells[i, 20].Value2),       // Runaway Accel
                     Convert.ToDouble(range.Cells[i, 22].Value2),       // Propulsion Removal
                     Convert.ToInt32(range.Cells[i, 24].Value2),        // Brake Build Up
                     Convert.ToInt32(range.Cells[i, 26].Value2));       // Overhand Distance
                    currentSheet.addRow(currentRow);
                    progressBox.progressBar1.PerformStep();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Loading File: " + e.ToString());
            }

            progressBox.Close();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int findFirstOccurrence()
        {
            for (int i = 1; i < mWorkBook.Sheets.Count; i++)
            {
                Excel._Worksheet worksheet = mWorkBook.Sheets[i];
                string name = worksheet.Name;
                if (name.Length >= 10 && (name.Substring(0, 10) == "Southbound" || name.Substring(0, 10) == "Northbound"))
                {
                    return i;
                }
            }
            return -1;
        }


    }


}
