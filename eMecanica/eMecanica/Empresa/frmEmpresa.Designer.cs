namespace eMecanica.Empresa
{
    partial class frmEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpresa));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.paneSuperior = new System.Windows.Forms.Panel();
            this.btMinimizar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btFechar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.paneCentral = new System.Windows.Forms.Panel();
            this.lbErro = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btGravar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btLimpar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtIdEmpresa = new System.Windows.Forms.TextBox();
            this.txtIdEndereco = new System.Windows.Forms.TextBox();
            this.txtTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.lbFixo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbCelular = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btLogo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btLayout = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lbBairro = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.lbNumero = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lbRua = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbbCidade = new System.Windows.Forms.ComboBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.lbCidade = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbEstado = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtInscMunicipal = new System.Windows.Forms.TextBox();
            this.lbInscMun = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtInscEstadual = new System.Windows.Forms.TextBox();
            this.lbInscEst = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btBuscaCep = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.lbCep = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lbCnpj = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.lbRazao = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbNome = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.paneSuperior.SuspendLayout();
            this.paneCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // paneSuperior
            // 
            this.paneSuperior.Controls.Add(this.btMinimizar);
            this.paneSuperior.Controls.Add(this.btFechar);
            this.paneSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneSuperior.Location = new System.Drawing.Point(0, 0);
            this.paneSuperior.Name = "paneSuperior";
            this.paneSuperior.Size = new System.Drawing.Size(682, 34);
            this.paneSuperior.TabIndex = 40;
            // 
            // btMinimizar
            // 
            this.btMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimizar.AutoSize = true;
            this.btMinimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(189)))));
            this.btMinimizar.Location = new System.Drawing.Point(625, 3);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(22, 26);
            this.btMinimizar.TabIndex = 5;
            this.btMinimizar.Text = "_";
            this.btMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click);
            // 
            // btFechar
            // 
            this.btFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFechar.AutoSize = true;
            this.btFechar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(189)))));
            this.btFechar.Location = new System.Drawing.Point(653, 4);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(26, 26);
            this.btFechar.TabIndex = 3;
            this.btFechar.Text = "X";
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // paneCentral
            // 
            this.paneCentral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneCentral.Controls.Add(this.lbErro);
            this.paneCentral.Controls.Add(this.btGravar);
            this.paneCentral.Controls.Add(this.btLimpar);
            this.paneCentral.Controls.Add(this.txtIdEmpresa);
            this.paneCentral.Controls.Add(this.txtIdEndereco);
            this.paneCentral.Controls.Add(this.txtTelefone2);
            this.paneCentral.Controls.Add(this.txtTelefone1);
            this.paneCentral.Controls.Add(this.lbFixo);
            this.paneCentral.Controls.Add(this.lbCelular);
            this.paneCentral.Controls.Add(this.pictureBox1);
            this.paneCentral.Controls.Add(this.btLogo);
            this.paneCentral.Controls.Add(this.btLayout);
            this.paneCentral.Controls.Add(this.txtReferencia);
            this.paneCentral.Controls.Add(this.bunifuCustomLabel13);
            this.paneCentral.Controls.Add(this.txtComplemento);
            this.paneCentral.Controls.Add(this.bunifuCustomLabel12);
            this.paneCentral.Controls.Add(this.txtBairro);
            this.paneCentral.Controls.Add(this.lbBairro);
            this.paneCentral.Controls.Add(this.txtNumero);
            this.paneCentral.Controls.Add(this.lbNumero);
            this.paneCentral.Controls.Add(this.txtRua);
            this.paneCentral.Controls.Add(this.lbRua);
            this.paneCentral.Controls.Add(this.cbbCidade);
            this.paneCentral.Controls.Add(this.cbbEstado);
            this.paneCentral.Controls.Add(this.lbCidade);
            this.paneCentral.Controls.Add(this.lbEstado);
            this.paneCentral.Controls.Add(this.txtInscMunicipal);
            this.paneCentral.Controls.Add(this.lbInscMun);
            this.paneCentral.Controls.Add(this.txtInscEstadual);
            this.paneCentral.Controls.Add(this.lbInscEst);
            this.paneCentral.Controls.Add(this.btBuscaCep);
            this.paneCentral.Controls.Add(this.txtCep);
            this.paneCentral.Controls.Add(this.lbCep);
            this.paneCentral.Controls.Add(this.txtCnpj);
            this.paneCentral.Controls.Add(this.lbCnpj);
            this.paneCentral.Controls.Add(this.txtNome);
            this.paneCentral.Controls.Add(this.txtRazao);
            this.paneCentral.Controls.Add(this.lbRazao);
            this.paneCentral.Controls.Add(this.lbNome);
            this.paneCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneCentral.Location = new System.Drawing.Point(0, 34);
            this.paneCentral.Name = "paneCentral";
            this.paneCentral.Size = new System.Drawing.Size(682, 591);
            this.paneCentral.TabIndex = 41;
            // 
            // lbErro
            // 
            this.lbErro.AutoSize = true;
            this.lbErro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErro.ForeColor = System.Drawing.Color.Red;
            this.lbErro.Location = new System.Drawing.Point(19, 365);
            this.lbErro.Name = "lbErro";
            this.lbErro.Size = new System.Drawing.Size(0, 17);
            this.lbErro.TabIndex = 80;
            this.lbErro.Visible = false;
            // 
            // btGravar
            // 
            this.btGravar.ActiveBorderThickness = 1;
            this.btGravar.ActiveCornerRadius = 20;
            this.btGravar.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btGravar.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btGravar.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btGravar.AutoScroll = true;
            this.btGravar.BackColor = System.Drawing.SystemColors.Control;
            this.btGravar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btGravar.BackgroundImage")));
            this.btGravar.ButtonText = "Gravar";
            this.btGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGravar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravar.ForeColor = System.Drawing.Color.Black;
            this.btGravar.IdleBorderThickness = 1;
            this.btGravar.IdleCornerRadius = 20;
            this.btGravar.IdleFillColor = System.Drawing.Color.Transparent;
            this.btGravar.IdleForecolor = System.Drawing.Color.Black;
            this.btGravar.IdleLineColor = System.Drawing.Color.Black;
            this.btGravar.Location = new System.Drawing.Point(455, 518);
            this.btGravar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(199, 46);
            this.btGravar.TabIndex = 69;
            this.btGravar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click_1);
            // 
            // btLimpar
            // 
            this.btLimpar.ActiveBorderThickness = 1;
            this.btLimpar.ActiveCornerRadius = 20;
            this.btLimpar.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btLimpar.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btLimpar.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btLimpar.AutoScroll = true;
            this.btLimpar.BackColor = System.Drawing.SystemColors.Control;
            this.btLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btLimpar.BackgroundImage")));
            this.btLimpar.ButtonText = "Limpar";
            this.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLimpar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.Color.Black;
            this.btLimpar.IdleBorderThickness = 1;
            this.btLimpar.IdleCornerRadius = 20;
            this.btLimpar.IdleFillColor = System.Drawing.Color.Transparent;
            this.btLimpar.IdleForecolor = System.Drawing.Color.Black;
            this.btLimpar.IdleLineColor = System.Drawing.Color.Black;
            this.btLimpar.Location = new System.Drawing.Point(268, 518);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(165, 46);
            this.btLimpar.TabIndex = 71;
            this.btLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click_1);
            // 
            // txtIdEmpresa
            // 
            this.txtIdEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdEmpresa.Location = new System.Drawing.Point(22, 390);
            this.txtIdEmpresa.Name = "txtIdEmpresa";
            this.txtIdEmpresa.Size = new System.Drawing.Size(10, 20);
            this.txtIdEmpresa.TabIndex = 79;
            this.txtIdEmpresa.Visible = false;
            this.txtIdEmpresa.TextChanged += new System.EventHandler(this.txtIdEmpresa_TextChanged);
            // 
            // txtIdEndereco
            // 
            this.txtIdEndereco.Location = new System.Drawing.Point(22, 364);
            this.txtIdEndereco.Name = "txtIdEndereco";
            this.txtIdEndereco.Size = new System.Drawing.Size(10, 20);
            this.txtIdEndereco.TabIndex = 78;
            this.txtIdEndereco.Visible = false;
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone2.HidePromptOnLeave = true;
            this.txtTelefone2.Location = new System.Drawing.Point(120, 124);
            this.txtTelefone2.Mask = "(99)0000-0000";
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(107, 23);
            this.txtTelefone2.TabIndex = 50;
            this.txtTelefone2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTelefone2_MaskInputRejected);
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone1.HidePromptOnLeave = true;
            this.txtTelefone1.Location = new System.Drawing.Point(455, 124);
            this.txtTelefone1.Mask = "(99)00000-0000";
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(107, 23);
            this.txtTelefone1.TabIndex = 49;
            this.txtTelefone1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTelefone1_MaskInputRejected);
            // 
            // lbFixo
            // 
            this.lbFixo.AutoSize = true;
            this.lbFixo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFixo.Location = new System.Drawing.Point(19, 127);
            this.lbFixo.Name = "lbFixo";
            this.lbFixo.Size = new System.Drawing.Size(95, 17);
            this.lbFixo.TabIndex = 77;
            this.lbFixo.Text = "Telefone Fixo*";
            this.lbFixo.Click += new System.EventHandler(this.lbFixo_Click);
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCelular.Location = new System.Drawing.Point(332, 127);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(111, 17);
            this.lbCelular.TabIndex = 76;
            this.lbCelular.Text = "Telefone Celular";
            this.lbCelular.Click += new System.EventHandler(this.lbCelular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(455, 363);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // btLogo
            // 
            this.btLogo.ActiveBorderThickness = 1;
            this.btLogo.ActiveCornerRadius = 20;
            this.btLogo.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btLogo.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btLogo.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btLogo.AutoScroll = true;
            this.btLogo.BackColor = System.Drawing.SystemColors.Control;
            this.btLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btLogo.BackgroundImage")));
            this.btLogo.ButtonText = "Carregar Logo";
            this.btLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogo.ForeColor = System.Drawing.Color.Black;
            this.btLogo.IdleBorderThickness = 1;
            this.btLogo.IdleCornerRadius = 20;
            this.btLogo.IdleFillColor = System.Drawing.Color.Transparent;
            this.btLogo.IdleForecolor = System.Drawing.Color.Black;
            this.btLogo.IdleLineColor = System.Drawing.Color.Black;
            this.btLogo.Location = new System.Drawing.Point(382, 310);
            this.btLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLogo.Name = "btLogo";
            this.btLogo.Size = new System.Drawing.Size(281, 46);
            this.btLogo.TabIndex = 67;
            this.btLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btLogo.Click += new System.EventHandler(this.btLogo_Click);
            // 
            // btLayout
            // 
            this.btLayout.ActiveBorderThickness = 1;
            this.btLayout.ActiveCornerRadius = 20;
            this.btLayout.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btLayout.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btLayout.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btLayout.AutoScroll = true;
            this.btLayout.BackColor = System.Drawing.SystemColors.Control;
            this.btLayout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btLayout.BackgroundImage")));
            this.btLayout.ButtonText = "Definir Layout";
            this.btLayout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLayout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLayout.ForeColor = System.Drawing.Color.Black;
            this.btLayout.IdleBorderThickness = 1;
            this.btLayout.IdleCornerRadius = 20;
            this.btLayout.IdleFillColor = System.Drawing.Color.Transparent;
            this.btLayout.IdleForecolor = System.Drawing.Color.Black;
            this.btLayout.IdleLineColor = System.Drawing.Color.Black;
            this.btLayout.Location = new System.Drawing.Point(22, 310);
            this.btLayout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLayout.Name = "btLayout";
            this.btLayout.Size = new System.Drawing.Size(346, 46);
            this.btLayout.TabIndex = 66;
            this.btLayout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btLayout.Click += new System.EventHandler(this.btLayout_Click);
            // 
            // txtReferencia
            // 
            this.txtReferencia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.Location = new System.Drawing.Point(101, 283);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(281, 23);
            this.txtReferencia.TabIndex = 65;
            this.txtReferencia.TextChanged += new System.EventHandler(this.txtReferencia_TextChanged);
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(19, 286);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(76, 17);
            this.bunifuCustomLabel13.TabIndex = 74;
            this.bunifuCustomLabel13.Text = "Referência";
            this.bunifuCustomLabel13.Click += new System.EventHandler(this.bunifuCustomLabel13_Click);
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(452, 254);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(204, 23);
            this.txtComplemento.TabIndex = 63;
            this.txtComplemento.TextChanged += new System.EventHandler(this.txtComplemento_TextChanged);
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(342, 257);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(104, 17);
            this.bunifuCustomLabel12.TabIndex = 73;
            this.bunifuCustomLabel12.Text = "Complemento";
            this.bunifuCustomLabel12.Click += new System.EventHandler(this.bunifuCustomLabel12_Click);
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(101, 254);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(233, 23);
            this.txtBairro.TabIndex = 61;
            this.txtBairro.TextChanged += new System.EventHandler(this.txtBairro_TextChanged);
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBairro.Location = new System.Drawing.Point(19, 254);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(50, 17);
            this.lbBairro.TabIndex = 72;
            this.lbBairro.Text = "Bairro*";
            this.lbBairro.Click += new System.EventHandler(this.lbBairro_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.HideSelection = false;
            this.txtNumero.Location = new System.Drawing.Point(527, 222);
            this.txtNumero.Mask = "00000000000000000";
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(129, 23);
            this.txtNumero.TabIndex = 60;
            this.txtNumero.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtNumero.ValidatingType = typeof(int);
            this.txtNumero.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtNumero_MaskInputRejected);
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(452, 228);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(66, 17);
            this.lbNumero.TabIndex = 70;
            this.lbNumero.Text = "Número*";
            this.lbNumero.Click += new System.EventHandler(this.lbNumero_Click);
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(101, 222);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(342, 23);
            this.txtRua.TabIndex = 58;
            this.txtRua.TextChanged += new System.EventHandler(this.txtRua_TextChanged);
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRua.Location = new System.Drawing.Point(19, 222);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(39, 17);
            this.lbRua.TabIndex = 68;
            this.lbRua.Text = "Rua*";
            this.lbRua.Click += new System.EventHandler(this.lbRua_Click);
            // 
            // cbbCidade
            // 
            this.cbbCidade.AccessibleName = "Cidade";
            this.cbbCidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCidade.FormattingEnabled = true;
            this.cbbCidade.Location = new System.Drawing.Point(384, 191);
            this.cbbCidade.Name = "cbbCidade";
            this.cbbCidade.Size = new System.Drawing.Size(272, 25);
            this.cbbCidade.TabIndex = 57;
            this.cbbCidade.SelectedIndexChanged += new System.EventHandler(this.cbbCidade_SelectedIndexChanged);
            // 
            // cbbEstado
            // 
            this.cbbEstado.AccessibleName = "Estado";
            this.cbbEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(101, 191);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(212, 25);
            this.cbbEstado.TabIndex = 56;
            this.cbbEstado.SelectedIndexChanged += new System.EventHandler(this.cbbEstado_SelectedIndexChanged_1);
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCidade.Location = new System.Drawing.Point(319, 192);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(63, 17);
            this.lbCidade.TabIndex = 64;
            this.lbCidade.Text = "Cidade*";
            this.lbCidade.Click += new System.EventHandler(this.lbCidade_Click);
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.Location = new System.Drawing.Point(19, 192);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(58, 17);
            this.lbEstado.TabIndex = 62;
            this.lbEstado.Text = "Estado*";
            this.lbEstado.Click += new System.EventHandler(this.lbEstado_Click);
            // 
            // txtInscMunicipal
            // 
            this.txtInscMunicipal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInscMunicipal.Location = new System.Drawing.Point(455, 95);
            this.txtInscMunicipal.Name = "txtInscMunicipal";
            this.txtInscMunicipal.Size = new System.Drawing.Size(201, 23);
            this.txtInscMunicipal.TabIndex = 47;
            this.txtInscMunicipal.TextChanged += new System.EventHandler(this.txtInscMunicipal_TextChanged);
            // 
            // lbInscMun
            // 
            this.lbInscMun.AutoSize = true;
            this.lbInscMun.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInscMun.Location = new System.Drawing.Point(318, 98);
            this.lbInscMun.Name = "lbInscMun";
            this.lbInscMun.Size = new System.Drawing.Size(137, 17);
            this.lbInscMun.TabIndex = 59;
            this.lbInscMun.Text = "Inscrição Municipal*";
            this.lbInscMun.Click += new System.EventHandler(this.lbInscMun_Click);
            // 
            // txtInscEstadual
            // 
            this.txtInscEstadual.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInscEstadual.Location = new System.Drawing.Point(145, 95);
            this.txtInscEstadual.Name = "txtInscEstadual";
            this.txtInscEstadual.Size = new System.Drawing.Size(167, 23);
            this.txtInscEstadual.TabIndex = 46;
            this.txtInscEstadual.TextChanged += new System.EventHandler(this.txtInscEstadual_TextChanged);
            // 
            // lbInscEst
            // 
            this.lbInscEst.AutoSize = true;
            this.lbInscEst.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInscEst.Location = new System.Drawing.Point(19, 98);
            this.lbInscEst.Name = "lbInscEst";
            this.lbInscEst.Size = new System.Drawing.Size(130, 17);
            this.lbInscEst.TabIndex = 55;
            this.lbInscEst.Text = "Inscrição Estadual*";
            this.lbInscEst.Click += new System.EventHandler(this.lbInscEst_Click);
            // 
            // btBuscaCep
            // 
            this.btBuscaCep.ActiveBorderThickness = 1;
            this.btBuscaCep.ActiveCornerRadius = 20;
            this.btBuscaCep.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btBuscaCep.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btBuscaCep.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btBuscaCep.AutoScroll = true;
            this.btBuscaCep.BackColor = System.Drawing.SystemColors.Control;
            this.btBuscaCep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBuscaCep.BackgroundImage")));
            this.btBuscaCep.ButtonText = "Buscar CEP";
            this.btBuscaCep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBuscaCep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscaCep.ForeColor = System.Drawing.Color.Black;
            this.btBuscaCep.IdleBorderThickness = 1;
            this.btBuscaCep.IdleCornerRadius = 20;
            this.btBuscaCep.IdleFillColor = System.Drawing.Color.Transparent;
            this.btBuscaCep.IdleForecolor = System.Drawing.Color.Black;
            this.btBuscaCep.IdleLineColor = System.Drawing.Color.Black;
            this.btBuscaCep.Location = new System.Drawing.Point(455, 151);
            this.btBuscaCep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBuscaCep.Name = "btBuscaCep";
            this.btBuscaCep.Size = new System.Drawing.Size(201, 36);
            this.btBuscaCep.TabIndex = 54;
            this.btBuscaCep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btBuscaCep.Click += new System.EventHandler(this.btBuscaCep_Click);
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.HidePromptOnLeave = true;
            this.txtCep.Location = new System.Drawing.Point(373, 155);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(70, 23);
            this.txtCep.TabIndex = 53;
            this.txtCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCep.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCep_MaskInputRejected);
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCep.Location = new System.Drawing.Point(318, 158);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(40, 17);
            this.lbCep.TabIndex = 52;
            this.lbCep.Text = "CEP*";
            this.lbCep.Click += new System.EventHandler(this.lbCep_Click);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.HidePromptOnLeave = true;
            this.txtCnpj.Location = new System.Drawing.Point(101, 155);
            this.txtCnpj.Mask = "00,000,000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(128, 23);
            this.txtCnpj.TabIndex = 51;
            this.txtCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCnpj.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCnpj_MaskInputRejected);
            // 
            // lbCnpj
            // 
            this.lbCnpj.AutoSize = true;
            this.lbCnpj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCnpj.Location = new System.Drawing.Point(19, 155);
            this.lbCnpj.Name = "lbCnpj";
            this.lbCnpj.Size = new System.Drawing.Size(49, 17);
            this.lbCnpj.TabIndex = 48;
            this.lbCnpj.Text = "CNPJ*";
            this.lbCnpj.Click += new System.EventHandler(this.lbCnpj_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(142, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(514, 23);
            this.txtNome.TabIndex = 45;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtRazao
            // 
            this.txtRazao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRazao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazao.Location = new System.Drawing.Point(116, 26);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(540, 23);
            this.txtRazao.TabIndex = 43;
            this.txtRazao.TextChanged += new System.EventHandler(this.txtRazao_TextChanged);
            // 
            // lbRazao
            // 
            this.lbRazao.AutoSize = true;
            this.lbRazao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRazao.Location = new System.Drawing.Point(19, 27);
            this.lbRazao.Name = "lbRazao";
            this.lbRazao.Size = new System.Drawing.Size(97, 17);
            this.lbRazao.TabIndex = 44;
            this.lbRazao.Text = "Razão Social*";
            this.lbRazao.Click += new System.EventHandler(this.lbRazao_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(19, 62);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(112, 17);
            this.lbNome.TabIndex = 42;
            this.lbNome.Text = "Nome Fantasia*";
            this.lbNome.Click += new System.EventHandler(this.lbNome_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 625);
            this.Controls.Add(this.paneCentral);
            this.Controls.Add(this.paneSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmpresa";
            this.paneSuperior.ResumeLayout(false);
            this.paneSuperior.PerformLayout();
            this.paneCentral.ResumeLayout(false);
            this.paneCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel paneSuperior;
        private Bunifu.Framework.UI.BunifuCustomLabel btMinimizar;
        private Bunifu.Framework.UI.BunifuCustomLabel btFechar;
        private System.Windows.Forms.Panel paneCentral;
        private Bunifu.Framework.UI.BunifuCustomLabel lbErro;
        private Bunifu.Framework.UI.BunifuThinButton2 btGravar;
        private Bunifu.Framework.UI.BunifuThinButton2 btLimpar;
        private System.Windows.Forms.TextBox txtIdEmpresa;
        private System.Windows.Forms.TextBox txtIdEndereco;
        private System.Windows.Forms.MaskedTextBox txtTelefone2;
        private System.Windows.Forms.MaskedTextBox txtTelefone1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbFixo;
        private Bunifu.Framework.UI.BunifuCustomLabel lbCelular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btLogo;
        private Bunifu.Framework.UI.BunifuThinButton2 btLayout;
        private System.Windows.Forms.TextBox txtReferencia;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private System.Windows.Forms.TextBox txtComplemento;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private System.Windows.Forms.TextBox txtBairro;
        private Bunifu.Framework.UI.BunifuCustomLabel lbBairro;
        private System.Windows.Forms.MaskedTextBox txtNumero;
        private Bunifu.Framework.UI.BunifuCustomLabel lbNumero;
        private System.Windows.Forms.TextBox txtRua;
        private Bunifu.Framework.UI.BunifuCustomLabel lbRua;
        private System.Windows.Forms.ComboBox cbbCidade;
        private System.Windows.Forms.ComboBox cbbEstado;
        private Bunifu.Framework.UI.BunifuCustomLabel lbCidade;
        private Bunifu.Framework.UI.BunifuCustomLabel lbEstado;
        private System.Windows.Forms.TextBox txtInscMunicipal;
        private Bunifu.Framework.UI.BunifuCustomLabel lbInscMun;
        private System.Windows.Forms.TextBox txtInscEstadual;
        private Bunifu.Framework.UI.BunifuCustomLabel lbInscEst;
        private Bunifu.Framework.UI.BunifuThinButton2 btBuscaCep;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private Bunifu.Framework.UI.BunifuCustomLabel lbCep;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private Bunifu.Framework.UI.BunifuCustomLabel lbCnpj;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRazao;
        private Bunifu.Framework.UI.BunifuCustomLabel lbRazao;
        private Bunifu.Framework.UI.BunifuCustomLabel lbNome;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}