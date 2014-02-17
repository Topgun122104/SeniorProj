using System;
using System.Windows.Forms;
using RailRoadSignal.EditorForms;

namespace RailRoadSignal
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /// <sumary>
            /// Runs the Application
            /// <sumary>
            using (Railroad_Signal application = new Railroad_Signal())
            {
                Application.Run(application);

            }
        }
    }

}

