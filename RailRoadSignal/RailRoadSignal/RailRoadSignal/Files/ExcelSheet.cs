using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailRoadSignal.Files
{
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