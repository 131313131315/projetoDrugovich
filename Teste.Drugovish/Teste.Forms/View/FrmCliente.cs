using System;
using System.Collections;
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
using static System.Net.Mime.MediaTypeNames;

namespace Teste.Forms.View
{
    public partial class FrmCliente : Form
    {
        public List<ClienteDto> listaCliente;
        public List<GrupoDto> listaGrupo;
        public FrmCliente()
        {
            InitializeComponent();

            if (FrmPrincipal.ger.Nivel == Domain.Enum.NivelGerente.Nivel1)
            {
                btnAlterar.Visible = false;             
            }
        }

        private void FrmCliente_Shown(object sender, EventArgs e)
        {

            listaCliente = ClienteApi.GetAll();
            listaGrupo = GrupoApi.GetAll();
            this.listView1.Items.Clear();

            foreach (var item in listaCliente)
            {
                ListViewItem view = new ListViewItem(item.Id.ToString());
                view.SubItems.Add(item.Nome.ToString());
                view.SubItems.Add(item.Cnpj.ToString());
                view.SubItems.Add(Convert.ToString(item.DataFundacao));
                view.SubItems.Add(item.NomeGrupo.ToString());
                this.listView1.Items.Add(view);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimparCampo()
        {
            txtNome.Text = "";
            txtCnpj.Text = "";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (btnAdicionar.Text == "Adicionar")
            {
                LimparCampo();
                btnAdicionar.Text = "Confirmar";
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = true;
                pnTopo.Enabled = true;
                txtNome.Focus();
                cbGrupo.ValueMember = "Id";
                cbGrupo.DisplayMember = "Nome";
                cbGrupo.DataSource = listaGrupo;
            }

            else
            {
                if (txtNome.Text == "")
                {
                    txtNome.Focus();
                    MessageBox.Show("Campo invalido");
                    return;
                }

                if (txtCnpj.Text == "")
                {
                    txtCnpj.Focus();
                    MessageBox.Show("Campo invalido");
                    return;
                }

                GrupoDto obj = cbGrupo.SelectedItem as GrupoDto;
                var cliente = new ClienteDto()
                {
                    Nome = txtNome.Text,
                    Cnpj = txtCnpj.Text,
                    DataFundacao = DateTime.Now,
                    GrupoId = obj.Id
                };
                var retorno = ClienteApi.AdicionarCliente(cliente);

                if (retorno == true)
                {

                    listaCliente = ClienteApi.GetAll();

                    this.listView1.Items.Clear();

                    foreach (var item in listaCliente)
                    {
                        ListViewItem view = new ListViewItem(item.Id.ToString());
                        view.SubItems.Add(item.Nome.ToString());
                        view.SubItems.Add(item.Cnpj.ToString());
                        view.SubItems.Add(item.DataFundacao.ToString());
                        view.SubItems.Add(item.NomeGrupo.ToString());
                        this.listView1.Items.Add(view);
                    }
                    btnAdicionar.Text = "Adicionar";
                    btnAlterar.Enabled = true;
                    btnExcluir.Enabled = true;
                    LimparCampo();
                    pnTopo.Enabled = false;
                    cbGrupo.DataSource = null;
                    MessageBox.Show("Adicionado com sucesso");
                    return;
                }
                else
                {
                    btnAdicionar.Text = "Adicionar";
                    btnCancelar.Enabled = false;
                    btnAlterar.Enabled = true;
                    btnExcluir.Enabled = true;
                    pnTopo.Enabled = false;
                    cbGrupo.DataSource = null;
                    LimparCampo();
                    MessageBox.Show("erro ao adicionar");
                    return;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnAdicionar.Enabled = true;
            btnAlterar.Enabled = true;
            pnTopo.Enabled = false;
            btnAdicionar.Text = "Adicionar";
            cbGrupo.DataSource = null;
            LimparCampo();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Selecione o registro");
                return;
            }

            GrupoDto obj = cbGrupo.SelectedItem as GrupoDto;
            var cliente = new ClienteDto()
            {
                Nome = txtNome.Text,
                GrupoId = obj.Id,
                Cnpj = txtCnpj.Text,
                Id = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text),
            };

            var retorno = ClienteApi.AlterarCliente(cliente);


            if (retorno == true)
            {

                listaCliente = ClienteApi.GetAll();

                this.listView1.Items.Clear();

                foreach (var item in listaCliente)
                {
                    ListViewItem view = new ListViewItem(item.Id.ToString());
                    view.SubItems.Add(item.Nome.ToString());
                    view.SubItems.Add(item.Cnpj.ToString());
                    view.SubItems.Add(item.DataFundacao.ToString("dd/MM/yyyy"));
                    view.SubItems.Add(item.NomeGrupo.ToString());
                    this.listView1.Items.Add(view);
                }

                pnTopo.Enabled = false;
                btnCancelar.Enabled = false;
                cbGrupo.DataSource = null;
                LimparCampo();
                MessageBox.Show("Alterado com sucesso");
                return;
            }
            else
            {
                pnTopo.Enabled = false;
                btnCancelar.Enabled = false;
                cbGrupo.DataSource = null;
                LimparCampo();
                MessageBox.Show("Alterado com sucesso");
                return;
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            cbGrupo.ValueMember = "Id";
            cbGrupo.DisplayMember = "Nome";
            cbGrupo.DataSource = listaGrupo;

            btnAdicionar.Text = "Adicionar";
            btnAlterar.Enabled = true;
            pnTopo.Enabled = true;
            txtNome.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtCnpj.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cbGrupo.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Selecione o registro");
                return;
            }
            
            var retorno = ClienteApi.DeletarCliente(Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));

            if (retorno == true)
            {

                listaCliente = ClienteApi.GetAll();

                this.listView1.Items.Clear();

                foreach (var item in listaCliente)
                {
                    ListViewItem view = new ListViewItem(item.Id.ToString());
                    view.SubItems.Add(item.Nome.ToString());
                    view.SubItems.Add(item.Cnpj.ToString());
                    view.SubItems.Add(item.DataFundacao.ToString("dd/MM/yyyy"));
                    view.SubItems.Add(item.NomeGrupo.ToString());
                    this.listView1.Items.Add(view);
                }

                pnTopo.Enabled = false;
                btnCancelar.Enabled = false;
                cbGrupo.DataSource = null;
                LimparCampo();
                MessageBox.Show("Deletado com sucesso");
                return;
            }
            else
            {
                pnTopo.Enabled = false;
                btnCancelar.Enabled = false;
                cbGrupo.DataSource = null;
                LimparCampo();
                MessageBox.Show("Erro");
                return;
            }
        }
    }
}
