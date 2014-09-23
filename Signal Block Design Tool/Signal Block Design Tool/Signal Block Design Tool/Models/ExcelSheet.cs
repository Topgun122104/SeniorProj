using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Block_Design_Tool.Files
{
    public class ExcelSheet
    {
        private List<ExcelRow> mRows;
        private int mCurrentRow = 0;

        public ExcelSheet()
        {
            mRows = new List<ExcelRow>();
        }

        public Boolean addRow(ExcelRow row)
        {
            mRows.Add(row);
            mCurrentRow++;
            return true;
        }

        public ExcelRow getRow(int i)
        {
            if (i <= mRows.Count)
                return mRows[i];
            else
                return null;
        }

        public int getCurrentRow()
        {
            return mCurrentRow;
        }
    }
}