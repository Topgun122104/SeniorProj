using System;
using System.Windows.Forms;
using Signal_Block_Design_Tool.Forms;

namespace Signal_Block_Design_Tool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignalBlockForm());
        } 
    }
}
