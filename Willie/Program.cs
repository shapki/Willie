using System;
using System.Windows.Forms;
using Willie.AppForms;
using Willie.Models;

namespace Willie
{
    static class Program
    {
        public static WillieModel context = new WillieModel();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!context.Database.Exists())
            {
                MessageBox.Show("Не удаётся подключитья к базе данных");
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
