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
                TrackLayout.Track.Add(new TrackSegment(
                    range.Cells[i, 2].Value2 != null ? Convert.ToInt32(range.Cells[i, 2].Value2) : currentSheet.getRow(currentRowInSheet - 1).getTrack(),              // Track
                    range.Cells[i, 3].Value2 != null ? range.Cells[i, 3].Value2 : currentSheet.getRow(currentRowInSheet - 1).getDirection(),                           // Direction
                    range.Cells[i, 4].Value2 != null ? range.Cells[i, 4].Value2 : currentSheet.getRow(currentRowInSheet - 1).getMove(),                                // Move
                    range.Cells[i, 5].Value2,                           // Circuit
                    Vector2.Zero,
                    Vector2.Zero,
                    Convert.ToInt32(range.Cells[i, 6].Value2),          // Brake Location
                    Convert.ToInt32(range.Cells[i, 7].Value2),          // Target Location
                    Convert.ToDouble(range.Cells[i, 9].Value2),         // Worst Grade
                    Convert.ToInt32(range.Cells[i, 10].Value2),         // Entry Speed
                    Convert.ToInt32(range.Cells[i, 11].Value2),         // Overspeed
                    Convert.ToDouble(range.Cells[i, 13].Value2),        // Acceleration
                    Convert.ToDouble(range.Cells[i, 15].Value2),        // Reaction Time
                    Convert.ToDouble(range.Cells[i, 17].Value2),        // Brake Rate
                    Convert.ToDouble(range.Cells[i, 20].Value2),        // Runaway Accel
                    Convert.ToDouble(range.Cells[i, 22].Value2),        // Propulsion Removal
                    Convert.ToInt32(range.Cells[i, 24].Value2),         // Brake Build Up
                    Convert.ToInt32(range.Cells[i, 26].Value2),         // Overhand Distance
                    Convert.ToDouble(range.Cells[i, 27].Value2)));      // Safety Factor

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
        /*
        static void Main(string[] args)
        {
            Program prog = new Program("C:\\Users\\ZacharyDesktop\\Documents\\GitHub\\SeniorProj\\Documents\\Research\\DART I3 - Safe Braking Distance -SBD Calculations_1_29_2014_Change Per C....xlsx");
            prog.processData();
            prog.cleanUp();
        }
        */

    }

    public class ExcelRow
    {
        private int mTrack;
        private String mDirection;
        private String mMoveNormRevDiv;
        private String mCircuit;
        private int mBrakeLocation;
        private int mTargetLocation;
        private double mWorstCaseGrade;
        private int mEntrySpeed;
        private double mOverspeed;
        private double mAcceleration;
        private double mReactionTime;
        private double mBrakeRate;
        private double mRunawayAccel;
        private double mPropulsionRemoval;
        private int mBrakeBuildUp;
        private int mOverhangDist;

        public ExcelRow()
        {
        }

        public ExcelRow(int track, String direction, String moveNormRevDiv, String circuit, int brakeLocation, int targetLocation, double worstCaseGrade,
            int entrySpeed, double overSpeed, double acceleration, double reactionTime, double brakeRate, double runawayAccel, double propulsionRemoval,
            int brakeBuildUp, int overhangDist)
        {
            mTrack = track;
            mDirection = direction;
            mMoveNormRevDiv = moveNormRevDiv;
            mCircuit = circuit;
            mBrakeLocation = brakeLocation;
            mTargetLocation = targetLocation;
            mWorstCaseGrade = worstCaseGrade;
            mEntrySpeed = entrySpeed;
            mOverspeed = overSpeed;
            mAcceleration = acceleration;
            mReactionTime = reactionTime;
            mBrakeRate = brakeRate;
            mRunawayAccel = runawayAccel;
            mPropulsionRemoval = propulsionRemoval;
            mBrakeBuildUp = brakeBuildUp;
            mOverhangDist = overhangDist;
        }

        public string displayRow()
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.Append(mTrack + " ");
            strBuild.Append(mDirection + " ");
            strBuild.Append(mMoveNormRevDiv + " ");
            strBuild.Append(mCircuit + " ");
            strBuild.Append(mBrakeLocation + " ");
            strBuild.Append(mTargetLocation + " ");
            strBuild.Append(mWorstCaseGrade + " ");
            strBuild.Append(mEntrySpeed + " ");
            strBuild.Append(mOverspeed + " ");
            strBuild.Append(mAcceleration + " ");
            strBuild.Append(mReactionTime + " ");
            strBuild.Append(mBrakeRate + " ");
            strBuild.Append(mRunawayAccel + " ");
            strBuild.Append(mPropulsionRemoval + " ");
            strBuild.Append(mBrakeBuildUp + " ");
            strBuild.Append(mOverhangDist + " ");
            strBuild.Append("\n");
            return strBuild.ToString();
        }

        public int getTrack()
        {
            return mTrack;
        }

        public string getDirection()
        {
            return mDirection;
        }

        public string getMove()
        {
            return mMoveNormRevDiv;
        }
    }

    public class ExcelSheet
    {
        private ExcelRow[] mRows;
        private int mCurrentRow = 0;
        private int mTotalRows;

        public ExcelSheet(int totalRows)
        {
            mRows = new ExcelRow[totalRows];
            mTotalRows = totalRows;
        }

        public ExcelSheet(int sheets, ExcelRow row)
        {
            mRows = new ExcelRow[sheets];
            mTotalRows = sheets;
            mRows[mCurrentRow] = row;
            mCurrentRow++;
        }

        public Boolean addRow(ExcelRow row)
        {
            if (mCurrentRow != mTotalRows)
            {
                mRows[mCurrentRow] = row;
                mCurrentRow++;
                return true;
            }
            return false;
        }

        public ExcelRow getRow(int i)
        {
            if (i < mTotalRows && i >= 0)
            {
                return mRows[i];
            }
            else
            {
                return null;
            }
        }

        public int getCurrentRow()
        {
            return mCurrentRow;
        }
    }
}
