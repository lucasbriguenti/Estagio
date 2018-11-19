namespace eMecanica
{
    partial class frmHome
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.paneSuperior = new System.Windows.Forms.Panel();
            this.btMinimizar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btMaximizar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btFechar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.servicoMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.paneMeio = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paneSuperior.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.paneMeio.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // paneSuperior
            // 
            this.paneSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.paneSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneSuperior.Controls.Add(this.btMinimizar);
            this.paneSuperior.Controls.Add(this.btMaximizar);
            this.paneSuperior.Controls.Add(this.btFechar);
            this.paneSuperior.Controls.Add(this.menuStrip);
            this.paneSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneSuperior.Location = new System.Drawing.Point(0, 0);
            this.paneSuperior.Name = "paneSuperior";
            this.paneSuperior.Size = new System.Drawing.Size(1217, 30);
            this.paneSuperior.TabIndex = 0;
            // 
            // btMinimizar
            // 
            this.btMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimizar.AutoSize = true;
            this.btMinimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(189)))));
            this.btMinimizar.Location = new System.Drawing.Point(1128, 0);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(22, 26);
            this.btMinimizar.TabIndex = 2;
            this.btMinimizar.Text = "_";
            this.btMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click);
            // 
            // btMaximizar
            // 
            this.btMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaximizar.AutoSize = true;
            this.btMaximizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMaximizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(189)))));
            this.btMaximizar.Location = new System.Drawing.Point(1156, 0);
            this.btMaximizar.Name = "btMaximizar";
            this.btMaximizar.Size = new System.Drawing.Size(24, 26);
            this.btMaximizar.TabIndex = 1;
            this.btMaximizar.Text = "⏍";
            this.btMaximizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMaximizar.Click += new System.EventHandler(this.btMaximizar_Click);
            // 
            // btFechar
            // 
            this.btFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFechar.AutoSize = true;
            this.btFechar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(189)))));
            this.btFechar.Location = new System.Drawing.Point(1186, 0);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(26, 26);
            this.btFechar.TabIndex = 0;
            this.btFechar.Text = "X";
            this.btFechar.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.menuStrip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servicoMenuStrip,
            this.clienteToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.fornecedorToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1215, 29);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // servicoMenuStrip
            // 
            this.servicoMenuStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(189)))));
            this.servicoMenuStrip.Name = "servicoMenuStrip";
            this.servicoMenuStrip.Size = new System.Drawing.Size(84, 25);
            this.servicoMenuStrip.Text = "Serviços";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.clienteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(189)))));
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cadastroToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(189)))));
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(189)))));
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem1});
            this.fornecedorToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(189)))));
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(111, 25);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // cadastroToolStripMenuItem1
            // 
            this.cadastroToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cadastroToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(189)))));
            this.cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            this.cadastroToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.cadastroToolStripMenuItem1.Text = "Cadastro";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(189)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(1117, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(100, 21);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "eMecanica";
            // 
            // paneMeio
            // 
            this.paneMeio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.paneMeio.Controls.Add(this.panel1);
            this.paneMeio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneMeio.Location = new System.Drawing.Point(0, 30);
            this.paneMeio.Name = "paneMeio";
            this.paneMeio.Size = new System.Drawing.Size(1217, 566);
            this.paneMeio.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 542);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 24);
            this.panel1.TabIndex = 0;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 596);
            this.Controls.Add(this.paneMeio);
            this.Controls.Add(this.paneSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.paneSuperior.ResumeLayout(false);
            this.paneSuperior.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.paneMeio.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel paneMeio;
        private System.Windows.Forms.Panel paneSuperior;
        private Bunifu.Framework.UI.BunifuCustomLabel btFechar;
        private Bunifu.Framework.UI.BunifuCustomLabel btMinimizar;
        private Bunifu.Framework.UI.BunifuCustomLabel btMaximizar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem servicoMenuStrip;
    }
}