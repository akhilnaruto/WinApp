using eTemple.Data.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eTemple.UI
{
    static class App
    {
        private static Logger _logger = LogManager.GetLogger("App Logger");

        public static Employee LoggedInEmployee { get; set; }

        public static MainForm AppMainForm { get; set; }

        public static long currentGovtNumber { get; set; }

        public static long maxGovtNumber { get; set; }

        public static int SlotMaxVal = 120;
        public static int DayMaxSlots = 12;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            //Application.Run(new MainForm());

            AppMainForm = new MainForm();
            Application.Run(AppMainForm);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.IsTerminating)
            {
                _logger.Warn("Application is terminating due to an unhandled exception in a secondary thread.");
            }
            _logger.Error(e.ExceptionObject);
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            _logger.Error(e.Exception);
        }

        public static void LogError(string errorMessage)
        {
            _logger.Error(errorMessage);
        }

        public static void LogError(Exception ex)
        {
            _logger.Error(ex);
        }
    }
}
