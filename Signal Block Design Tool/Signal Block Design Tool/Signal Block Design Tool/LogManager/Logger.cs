using Signal_Block_Design_Tool.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Block_Design_Tool.LogManager
{
    public static class Logger
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        public static void Log(String text)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(Config.ConfigManager.LogFile))
            {
                try
                {

                    string toWrite = string.Format("{0}\t{1}\t\n", DateTime.Now, text);
                    file.WriteLine(toWrite);
                    ErrorForm error = new ErrorForm();
                    error.SetText(text);
                    error.ShowDialog();
                }
                catch (Exception e)
                {
                    ErrorForm error = new ErrorForm();
                    error.SetText(e.Message);
                    error.ShowDialog();
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ex"></param>
        public static void Log(Exception ex)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(Config.ConfigManager.LogFile))
            {
                try
                {
                    string toWrite = string.Format("{0}\t{1}\t\n", DateTime.Now, ex.Message, ex.StackTrace);
                    file.WriteLine(toWrite);
                    ErrorForm error = new ErrorForm();
                    error.SetText(ex.Message);
                    error.ShowDialog();
                }
                catch (Exception e)
                {
                    ErrorForm error = new ErrorForm();
                    error.SetText(e.Message);
                    error.ShowDialog();

                }
            }
        }


    }
}
