using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace InputFileParsing
{
    class Program
    {
        String mFilename;
        Excel.Workbook mWorkBook;
        Excel.Application mApp;
        public Program(String filename) 
        {
            mFilename = filename;
            mApp = new Excel.Application();
            mWorkBook = mApp.Workbooks.Open(mFilename);
        }

        public void processData()
        {
            int sheets = mWorkBook.Sheets.Count;
            for(int i = 1; i <= mWorkBook.Sheets.Count; i++)
            {
                Excel._Worksheet worksheet = mWorkBook.Sheets[1];
                getData(worksheet);
                worksheet = mWorkBook.Sheets[i];
                Marshal.ReleaseComObject(worksheet);
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

        public void getData(Excel._Worksheet worksheet)
        {
            Excel.Range range = worksheet.UsedRange;
            int rows = range.Rows.Count;
            int cols = range.Rows.Count;
            for (int i = 4; i <= rows; i++)
            {
                
                for (int j = 1; j <= cols; j++)
                {
                    if (j == 1)
                    {
                        Console.Write("\r\n");
                    }

                    if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                    {
                        Console.Write(range.Cells[i, j].Value2 + "\t");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
           Program prog = new Program("C:\\Users\\ZacharyDesktop\\Documents\\GitHub\\SeniorProj\\InputFileParsing\\testdata.xlsx");
           prog.processData();
           prog.cleanUp();
        }
    }
}
