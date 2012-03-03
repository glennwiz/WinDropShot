﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinDropShot
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
            
            var mn = new Main();
            mn.Hide();

            Application.Run();  
        }
    }
}
