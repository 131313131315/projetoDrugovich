namespace Teste.Forms.View
{
    partial class FrmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            Grupo = new ColumnHeader();
            panel1 = new Panel();
            btnExcluir = new Button();
            pnTopo = new Panel();
            label3 = new Label();
            txtCnpj = new MaskedTextBox();
            cbGrupo = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txtNome = new TextBox();
            btnSair = new Button();
            btnAlterar = new Button();
            btnCancelar = new Button();
            btnAdicionar = new Button();
            panel1.SuspendLayout();
            pnTopo.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, Grupo });
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(0, 100);
            listView1.Name = "listView1";
            listView1.Size = new Size(1183, 491);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.Click += listView1_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nome";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Cnpj";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Data Fundação";
            columnHeader4.Width = 180;
            // 
            // Grupo
            // 
            Grupo.Text = "Grupo";
            Grupo.Width = 150;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(pnTopo);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnAlterar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnAdicionar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 100);
            panel1.TabIndex = 1;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(835, 25);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(102, 38);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // pnTopo
            // 
            pnTopo.Controls.Add(label3);
            pnTopo.Controls.Add(txtCnpj);
            pnTopo.Controls.Add(cbGrupo);
            pnTopo.Controls.Add(label2);
            pnTopo.Controls.Add(label1);
            pnTopo.Controls.Add(txtNome);
            pnTopo.Dock = DockStyle.Left;
            pnTopo.Enabled = false;
            pnTopo.Location = new Point(0, 0);
            pnTopo.Name = "pnTopo";
            pnTopo.Size = new Size(502, 100);
            pnTopo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 23);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Grupo";
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(226, 41);
            txtCnpj.Mask = "99,999,999-9999/99";
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(132, 23);
            txtCnpj.TabIndex = 5;
            // 
            // cbGrupo
            // 
            cbGrupo.FormattingEnabled = true;
            cbGrupo.Location = new Point(364, 41);
            cbGrupo.Name = "cbGrupo";
            cbGrupo.Size = new Size(117, 23);
            cbGrupo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 22);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 3;
            label2.Text = "Cnpj";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 22);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(3, 41);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(207, 23);
            txtNome.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(943, 25);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(102, 38);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(724, 25);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(102, 38);
            btnAlterar.TabIndex = 2;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new Point(616, 25);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 38);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdicionar.Location = new Point(508, 25);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(102, 38);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 591);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Name = "FrmCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCliente";
            Shown += FrmCliente_Shown;
            panel1.ResumeLayout(false);
            pnTopo.ResumeLayout(false);
            pnTopo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Panel panel1;
        private Button btnSair;
        private Button btnAlterar;
        private Button btnCancelar;
        private Button btnAdicionar;
        private Panel pnTopo;
        private Label label2;
        private Label label1;
        private TextBox txtNome;
        private MaskedTextBox txtCnpj;
        private ComboBox cbGrupo;
        private ColumnHeader Grupo;
        private Label label3;
        private Button btnExcluir;
    }
}