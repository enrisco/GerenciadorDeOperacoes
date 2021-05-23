using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projGerenciadorDeOperacoes.View;
using System.Windows.Forms;

namespace projGerenciadorDeOperacoes.Controller
{
    static class LeftBarController
    {
        public static void SpawnUserControl(string control, Panel conteiner)
        {
            ClearConteiner(conteiner);
            if (control == "Cadastrar Cliente")
                conteiner.Controls.Add(new ControlAddClient());
            else if (control == "Ver Relátorios")
                conteiner.Controls.Add(new ControlReportViewer());
            else if (control == "Adicionar Moeda")
                conteiner.Controls.Add(new ControlAddCoin());

            conteiner.Controls[0].Anchor = 
            (
                AnchorStyles.Bottom | 
                AnchorStyles.Right | 
                AnchorStyles.Left | 
                AnchorStyles.Top
            );
            conteiner.Controls[0].Dock = DockStyle.Fill;
        }

        static void ClearConteiner(Panel conteiner)
        {
            conteiner.Controls.Clear();
        }
    }
}
