﻿using CourseProject.custom_form;
using System;
using System.Windows.Forms;

namespace CourseProject
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AdminMenuForm("aprox512"));
        }
    }
}
