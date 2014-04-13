using System;
using System.Windows.Forms;
using RailRoadSignal.EditorForms;
using RailRoadSignal.Database;
using System.Collections.Generic;

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

            /*DatabaseConnection conn = new 
                DatabaseConnection("andrew.cs.fit.edu", 3306, "signalblockdesign", "signalblockdesig", "E2SnzbV922m6R51");

             */
           
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

