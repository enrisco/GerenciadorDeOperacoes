using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projGerenciadorDeOperacoes.Controller;

namespace projGerenciadorDeOperacoes.View
{
    public partial class ControlReportViewer : UserControl
    {
        public ControlReportViewer()
        {
            InitializeComponent();

            dataGridView.DataSource = DataController.CreateTable();
            UpdateSum();
        }

        private void CheckBoxUseDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUseDate.Checked)
                dateTimePicker.Enabled = true;
            else
                dateTimePicker.Enabled = false;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (checkBoxUseDate.Checked)
            {
                dataGridView.DataSource = DataController.Search(textBoxSearchName.Text, dateTimePicker.Text);
                UpdateSum();
            }
            else
            {
                dataGridView.DataSource = DataController.Search(textBoxSearchName.Text, "");
                UpdateSum();
            }
        }

        private void UpdateSum()
        {
            textBoxOpe.Text = DataController.SumOpe.ToString("F", CultureInfo.InvariantCulture);
            textBoxTax.Text = DataController.SumTax.ToString("F", CultureInfo.InvariantCulture);
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = DataController.Search("", "");
            UpdateSum();
        }
    }
}
