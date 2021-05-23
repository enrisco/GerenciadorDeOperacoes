using System;
using System.Globalization;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projGerenciadorDeOperacoes.Model;
using projGerenciadorDeOperacoes.Controller;

namespace projGerenciadorDeOperacoes.View
{
    public partial class ControlAddCoin : UserControl
    {
        DatabaseController data = new DatabaseController();
        public ControlAddCoin()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text != "" && textBoxValue.Text != "")
            {
                Coin c = new Coin
                {
                    CoinName = textBoxName.Text,
                    Value = Convert.ToDouble(textBoxValue.Text, CultureInfo.InvariantCulture)
                };

                if (!data.CheckIfElementExist("Coin",c.CoinName))
                {
                    data.Add(c);
                    DialogBoxController.ShowWarning("Câmbio adicionado.");
                }
                else
                    DialogBoxController.ShowError("Câmbio já cadastrado.");
            }
            else
            {
                DialogBoxController.ShowError("Preencha todos os campos antes de continuar.");
            }
        }
    }
}
