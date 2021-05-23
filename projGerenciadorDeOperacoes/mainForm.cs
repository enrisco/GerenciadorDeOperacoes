using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projGerenciadorDeOperacoes.Controller;

namespace projGerenciadorDeOperacoes
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            LeftBarController.SpawnUserControl("Cadastrar Cliente", panelConteiner);
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LeftBarController.SpawnUserControl(ListBoxMenuBar.SelectedItem.ToString(), panelConteiner);
        }
    }
}
