﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using projGerenciadorDeOperacoes.Controller;

namespace projGerenciadorDeOperacoes
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (UseXML.CheckifXMLDontExist())
                UseXML.CreateDatabase();
            Application.Run(new mainForm());
        }
    }
}
