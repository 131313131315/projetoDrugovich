namespace Teste.Forms.View
{
    partial class FrmGrupo
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
            panel1 = new Panel();
            btnExcluir = new Button();
            pnTopo = new Panel();
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
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(0, 100);
            listView1.Name = "listView1";
            listView1.Size = new Size(978, 350);
            listView1.TabIndex = 2;
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
            panel1.Size = new Size(978, 100);
            panel1.TabIndex = 3;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(621, 32);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(102, 38);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // pnTopo
            // 
            pnTopo.Controls.Add(label1);
            pnTopo.Controls.Add(txtNome);
            pnTopo.Dock = DockStyle.Left;
            pnTopo.Enabled = false;
            pnTopo.Location = new Point(0, 0);
            pnTopo.Name = "pnTopo";
            pnTopo.Size = new Size(275, 100);
            pnTopo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 41);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(207, 23);
            txtNome.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(729, 32);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(102, 38);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(513, 31);
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
            btnCancelar.Location = new Point(405, 31);
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
            btnAdicionar.Location = new Point(297, 31);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(102, 38);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // FrmGrupo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 450);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Name = "FrmGrupo";
            Text = "FrmGrupo";
            Shown += FrmGrupo_Shown;
            panel1.ResumeLayout(false);
            pnTopo.ResumeLayout(false);
            pnTopo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Panel panel1;
        private Panel pnTopo;
        private Label label1;
        private TextBox txtNome;
        private Button btnSair;
        private Button btnAlterar;
        private Button btnCancelar;
        private Button btnAdicionar;
        private Button btnExcluir;
    }
}