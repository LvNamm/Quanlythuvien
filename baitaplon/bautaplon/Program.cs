﻿using bautaplon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythuvien
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
            FormMenuchucnang a = new FormMenuchucnang();
            a.FormBorderStyle = FormBorderStyle.FixedSingle;
            Application.Run(a);
        }
    }
}
