using System;
using System.Globalization;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projGerenciadorDeOperacoes.Controller;
using projGerenciadorDeOperacoes.Model; 

namespace projGerenciadorDeOperacoes.View
{
    public partial class ControlAddClient : UserControl
    {
        string[] coins;
        double firstValue;
        DatabaseController data = new DatabaseController();
        public ControlAddClient()
        {
            coins = data.GetNameOfElements("Coin");
            InitializeComponent();

            PopulateComboBox(comboBoxCoin, coins);
            PopulateComboBox(comboBoxDestination, coins);
        }

        private void PopulateComboBox(ComboBox cb, string[] value)
        {
            foreach (var item in value)
            {
                cb.Items.Add(item);
            }
        }

        private void CheckBoxToday_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxToday.Checked)
                dateTimePicker.Enabled = true;
            else
            {
                dateTimePicker.Enabled = false;
                dateTimePicker.Value = DateTime.Now;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxValues())
            {
                Client c = new Client
                {
                    Name = textBoxName.Text,
                    Date = dateTimePicker.Value.ToString(),
                    Initial = comboBoxCoin.Text,
                    Converted = comboBoxDestination.Text,
                    InitialValue = Convert.ToDouble(textBoxFirstValue.Text, CultureInfo.InvariantCulture),
                    ConvertedValue = Convert.ToDouble(textBoxFinalValue.Text, CultureInfo.InvariantCulture),
                    TaxValue = Convert.ToDouble(textBoxTax.Text, CultureInfo.InvariantCulture)
                };

                if (!data.CheckIfElementExist("Client",c.Name))
                {
                    data.Add(c);
                    DialogBoxController.ShowWarning("Cliente adicionado.");
                }
                else
                    DialogBoxController.ShowError("Cliente já cadastrado.");
            }
            else
            {
                DialogBoxController.ShowError("Preencha todos os campos antes de continuar.");
            }
        }

        private bool CheckTextBoxValues()
        {
            if (textBoxName.Text != "" && textBoxFirstValue.Text != "" && comboBoxCoin.Text != "" && comboBoxDestination.Text != "")
                return true;
            else
                return false;
        }

        private void TextBoxFirstValue_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxFirstValue.Text, out firstValue) && textBoxFirstValue.Text != "")
            {
                DialogBoxController.ShowError("Digite apenas números ou números separados por vírgula.");
                textBoxFirstValue.Text = string.Empty;
            }
            else
                UpdateTaxAndConvertedValue();
        }

        private void ComboBoxCoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTaxAndConvertedValue();
        }

        private void ComboBoxDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTaxAndConvertedValue();
        }

        private void UpdateTaxAndConvertedValue()
        {
            if (textBoxFirstValue.Text != "")
            {
                double d;
                Converter c = new Converter
                {
                    First = data.GetCoin(comboBoxCoin.Text),
                    Destination = data.GetCoin(comboBoxDestination.Text)
                };

                d= c.UnityConverter(double.Parse(textBoxFirstValue.Text, CultureInfo.InvariantCulture));

                textBoxFinalValue.Text = d.ToString("F", CultureInfo.InvariantCulture) ;
                textBoxTax.Text = ((10 * d) / 100).ToString("F", CultureInfo.InvariantCulture);
            }
        }
    }
}
