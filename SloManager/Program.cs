using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SloManager
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string dbSourcePath = Path.Combine(Application.StartupPath, "SloDatabase.mdf");
            string dbDestFolder = @"C:\ProgramData\SLOApp";
            string dbDestPath = Path.Combine(dbDestFolder, "SloDatabase.mdf");

            try
            {
                if (!File.Exists(dbDestPath))
                {
                    Directory.CreateDirectory(dbDestFolder);
                    File.Copy(dbSourcePath, dbDestPath);
                }

                // Tell EF where the database is
                AppDomain.CurrentDomain.SetData("DataDirectory", dbDestFolder);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to initialize database: " + ex.Message);
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
