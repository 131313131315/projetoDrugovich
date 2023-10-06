using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste.Domain.Entities;
using Teste.Domain.Enum;

namespace Teste.Forms.View
{

    public partial class FrmPrincipal : Form
    {
        public static Gerente ger = new Gerente();

        public FrmPrincipal(Gerente gerente)
        {
            InitializeComponent();
            ger = gerente;

            lblGerente.Text = ger.Nome;
        }

        private void clientesMenu_Click(object sender, EventArgs e)
        {
            FrmCliente tela = new FrmCliente();
            tela.ShowDialog();
        }

        private void grupoMenu_Click(object sender, EventArgs e)
        {
            FrmGrupo tela = new FrmGrupo();
            tela.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
