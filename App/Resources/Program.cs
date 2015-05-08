﻿////*********************************************************
//
//    <copyright file="Program.cs" company="Marketing Software de Colombia LTDA">
//    @Autor Ingrid Sutachan
//    @fecha 01 marzo 2014
//    </copyright>
//
////*********************************************************
namespace App
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

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
            Application.Run(new Forms.Contable.Frmmenucont());
        }
        public static int iduser = 1;
        public static int compa = 1;
    }
}
