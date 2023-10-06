using Microsoft.VisualBasic.Logging;
using Teste.Domain.Entities;
using Teste.Forms.Api;

namespace Teste.Forms.View
{
    public partial class FrmLogin : Form
    {
        public Gerente gerente = new Gerente();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Gerente result;
            try
            {
                result = GerenteApi.RealizarLogin(txtGerente.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error ao realizar login, tente novamente mais tarde");
                gerente = null;
                return;
            }

            if (result.Id != 0)
            {
                gerente = result;
                this.Close();
            }
            else
            {
                this.txtGerente.Text = "";
                MessageBox.Show("Gerente não encontrado !");
                this.txtGerente.Focus();
            }
        }
    }
}
