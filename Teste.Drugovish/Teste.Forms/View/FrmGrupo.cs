using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste.Domain.Dtos.Cliente;
using Teste.Domain.Dtos.Grupo;
using Teste.Domain.Entities;
using Teste.Forms.Api;

namespace Teste.Forms.View
{
    public partial class FrmGrupo : Form
    {
        public List<GrupoDto> listaGrupo;
        public FrmGrupo()
        {
            InitializeComponent();

            if (FrmPrincipal.ger.Nivel == Domain.Enum.NivelGerente.Nivel1)
            {
                btnAlterar.Visible = false;
                btnAdicionar.Visible = false;
                btnCancelar.Visible = false;
                btnExcluir.Visible = false;
                pnTopo.Visible = false;
            }
        }

        private void LimparCampo()
        {
            txtNome.Text = "";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (btnAdicionar.Text == "Adicionar")
            {
                LimparCampo();
                btnAdicionar.Text = "Confirmar";
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
                btnCancelar.Enabled = true;
                pnTopo.Enabled = true;
                txtNome.Focus();
            }
            else
            {
                if (txtNome.Text == "")
                {
                    txtNome.Focus();
                    MessageBox.Show("Campo invalido");
                    return;
                }
                var grupo = new GrupoDto()
                {
                    Nome = txtNome.Text,
                };
                var retorno = GrupoApi.AdicionarGrupo(grupo);

                if (retorno == true)
                {

                    listaGrupo = GrupoApi.GetAll();

                    this.listView1.Items.Clear();

                    foreach (var item in listaGrupo)
                    {
                        ListViewItem view = new ListViewItem(item.Id.ToString());
                        view.SubItems.Add(item.Nome.ToString());
                        this.listView1.Items.Add(view);
                    }
                    btnAdicionar.Text = "Adicionar";
                    btnAlterar.Enabled = true;
                    btnExcluir.Enabled = true;
                    LimparCampo();
                    pnTopo.Enabled = false;
                    MessageBox.Show("Adicionado com sucesso");
                    return;
                }
                else
                {
                    btnAdicionar.Text = "Adicionar";
                    btnCancelar.Enabled = false;
                    btnExcluir.Enabled = true;
                    btnAlterar.Enabled = true;
                    pnTopo.Enabled = false;
                    LimparCampo();
                    MessageBox.Show("erro ao adicionar");
                    return;
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Selecione o registro");
                return;
            }
            var grupo = new GrupoDto()
            {
                Nome = txtNome.Text,
                Id = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text),
            };
            var retorno = GrupoApi.AlterarGrupo(grupo);
            if (retorno == true)
            {
                listaGrupo = GrupoApi.GetAll();
                this.listView1.Items.Clear();
                foreach (var item in listaGrupo)
                {
                    ListViewItem view = new ListViewItem(item.Id.ToString());
                    view.SubItems.Add(item.Nome.ToString());
                    this.listView1.Items.Add(view);
                }
                pnTopo.Enabled = false;
                btnCancelar.Enabled = false;
                LimparCampo();
                MessageBox.Show("Alterado com sucesso");
                return;
            }
            else
            {
                pnTopo.Enabled = false;
                btnCancelar.Enabled = false;
                LimparCampo();
                MessageBox.Show("Alterado com sucesso");
                return;
            }
        }

        private void FrmGrupo_Shown(object sender, EventArgs e)
        {

            listaGrupo = GrupoApi.GetAll();

            this.listView1.Items.Clear();

            foreach (var item in listaGrupo)
            {
                ListViewItem view = new ListViewItem(item.Id.ToString());
                view.SubItems.Add(item.Nome.ToString());
                this.listView1.Items.Add(view);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnAdicionar.Enabled = true;
            btnAlterar.Enabled = true;
            pnTopo.Enabled = false;
            btnAdicionar.Text = "Adicionar";
            LimparCampo();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            btnAdicionar.Text = "Adicionar";
            btnAlterar.Enabled = true;
            pnTopo.Enabled = true;
            txtNome.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Selecione o registro");
                return;
            }

            var retorno = GrupoApi.DeletarGrupo(Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));

            if (retorno == true)
            {

                listaGrupo = GrupoApi.GetAll();

                this.listView1.Items.Clear();

                foreach (var item in listaGrupo)
                {
                    ListViewItem view = new ListViewItem(item.Id.ToString());
                    view.SubItems.Add(item.Nome.ToString());
                    this.listView1.Items.Add(view);
                }

                pnTopo.Enabled = false;
                btnCancelar.Enabled = false;                
                LimparCampo();
                MessageBox.Show("Deletado com sucesso");
                return;
            }
            else
            {
                pnTopo.Enabled = false;
                btnCancelar.Enabled = false;                
                LimparCampo();
                MessageBox.Show("Grupo não pode ser excluido");
                return;
            }
        }
    }
}
