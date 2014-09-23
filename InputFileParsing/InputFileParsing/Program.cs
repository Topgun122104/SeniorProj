using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.IO;

namespace InputFileParsing
{
    class Program
    {
        String mFilename;

        /// <summary>
        /// Excel Parser Constructor
        /// </summary>
        /// <param name="filename"></param>
        public Program(String filename)
        {
            mFilename = filename;
        }


        public void processData()
        {
            ExcelSheet sheet = new ExcelSheet();
            using(StreamReader file = new StreamReader(mFilename))
            {
                string line = null;
                string[] row;
                // Get to the data
                while (line == null || line.Split(',')[1] != "Track")
                {
                    line = file.ReadLine();
                }
                // Parse the data
                while((line = file.ReadLine()) != null)
                {
                    row = line.Split(',');
                    // If this cell does not have data then there is no more data.
                    if (row[4] == "")
                    {
                        break;
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
                    ExcelRow curRow = new ExcelRow(
                                                    row[1] != "" ? Convert.ToInt32(row[1]) : (sheet.getRow(sheet.getCurrentRow() - 1)).getTrack(),  // Track
                                                    row[2] != "" ? row[2] : (sheet.getRow(sheet.getCurrentRow() - 1)).getDirection(),               // Direction
                                                    row[3] != "" ? row[3] : (sheet.getRow(sheet.getCurrentRow() - 1)).getMove(),                    // Move
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
                    sheet.addRow(curRow);
                }
            }
        }

        static void Main(string[] args)
        {
            Program prog = new Program("C:\\Users\\ZacharyDesktop\\Documents\\GitHub\\SeniorProj\\Documents\\Research\\DART I3 - Safe Braking Distance -SBD Calculations_1_29_2014_Change Per C....csv");
            prog.processData();
        }
    }


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
    private double mEntrySpeed;
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
        double entrySpeed, double overSpeed, double acceleration, double reactionTime, double brakeRate, double runawayAccel, double propulsionRemoval,
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
    private List<ExcelRow> list;
    private int mCurrentRow = 0;
    private int mTotalRows;

    public ExcelSheet()
    {
        list = new List<ExcelRow>();
    }

    public Boolean addRow(ExcelRow row)
    {
        list.Add(row);
        mCurrentRow++;
        return true;
    }

    public ExcelRow getRow(int i)
    {
        if (i <= list.Count)
            return list[i];
        else
            return null;
    }

    public int getCurrentRow()
    {
        return mCurrentRow;
    }
}
//}
