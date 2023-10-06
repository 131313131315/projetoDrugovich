namespace Teste.Forms.View
{
    partial class FrmPrincipal
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
            menu = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clientesMenu = new ToolStripMenuItem();
            grupoMenu = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            lblGerente = new Label();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, sairToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(800, 24);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesMenu, grupoMenu });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesMenu
            // 
            clientesMenu.Name = "clientesMenu";
            clientesMenu.Size = new Size(111, 22);
            clientesMenu.Text = "Cliente";
            clientesMenu.Click += clientesMenu_Click;
            // 
            // grupoMenu
            // 
            grupoMenu.Name = "grupoMenu";
            grupoMenu.Size = new Size(111, 22);
            grupoMenu.Text = "Grupo";
            grupoMenu.Click += grupoMenu_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // lblGerente
            // 
            lblGerente.AutoSize = true;
            lblGerente.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblGerente.Location = new Point(27, 49);
            lblGerente.Name = "lblGerente";
            lblGerente.Size = new Size(0, 32);
            lblGerente.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGerente);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            WindowState = FormWindowState.Maximized;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clientesMenu;
        private ToolStripMenuItem grupoMenu;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Label lblGerente;
    }
}