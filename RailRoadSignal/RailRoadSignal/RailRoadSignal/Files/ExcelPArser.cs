using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Xna.Framework;
using Excel = Microsoft.Office.Interop.Excel;
using RailRoadSignal.Files;
using System.Windows.Forms;
using RailRoadSignal.EditorForms;
using System.Threading;


namespace RailRoadSignal.Files
{
    public class ExcelParser
    {
        String mFilename;
        Excel.Workbook mWorkBook;
        Excel.Application mApp;
        ExcelSheet[] safeBreakingSheets;
        public ExcelParser(String filename)
        {
            mFilename = filename;
            mApp = new Excel.Application();
            mWorkBook = mApp.Workbooks.Open(mFilename);
            ProgressBoxForm p = new ProgressBoxForm();
            p.Visible = true;
            p.Show();

            for (int i = 0; i < 100; i++)
            {
                p.progressBar1.PerformStep();
                Thread.Sleep(10);
            }

        }

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
                    safeBreakingSheets[i - begin] = getData(worksheet);
                    Marshal.ReleaseComObject(worksheet);
                }
            }
        }

        public void cleanUp()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            mWorkBook.Close();
            Marshal.ReleaseComObject(mWorkBook);

            mApp.Quit();
            Marshal.ReleaseComObject(mApp);

        }

        public void FillData()
        {
             
        }
        public ExcelSheet getData(Excel._Worksheet worksheet)
        {

            ProgressBoxForm progressBox = new ProgressBoxForm();
            progressBox.ShowDialog();

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
