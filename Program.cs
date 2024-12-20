using System;
using System.Windows.Forms;

namespace photoReader
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            Application.Run(new Mainwindow());
        }
    }
}