﻿using System;
using System.Windows.Forms;

namespace DodzeBuilder
{
    internal static class Runtime
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DodzeMain());
        }
    }
}
