using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLySinhVien.GUI;
using QuanLySinhVien.Common;

namespace QuanLySinhVien
{
    static class Program
    {
        public static Form MainForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             MainForm = new MainStudent();
            Application.Run(new DangNhap());
            //Application.Run(MainForm);
        }
    }
}
