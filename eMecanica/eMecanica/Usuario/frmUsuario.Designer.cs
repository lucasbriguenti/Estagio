namespace eMecanica.Usuario
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.paneCentral = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btBuscar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgvUsuarios = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.paneCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // paneCentral
            // 
            this.paneCentral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneCentral.Controls.Add(this.dgvUsuarios);
            this.paneCentral.Controls.Add(this.btBuscar);
            this.paneCentral.Controls.Add(this.txtBusca);
            this.paneCentral.Controls.Add(this.panel1);
            this.paneCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneCentral.Location = new System.Drawing.Point(0, 0);
            this.paneCentral.Name = "paneCentral";
            this.paneCentral.Size = new System.Drawing.Size(745, 395);
            this.paneCentral.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 27);
            this.panel1.TabIndex = 0;
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(11, 58);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(546, 27);
            this.txtBusca.TabIndex = 1;
            // 
            // btBuscar
            // 
            this.btBuscar.ActiveBorderThickness = 1;
            this.btBuscar.ActiveCornerRadius = 20;
            this.btBuscar.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btBuscar.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btBuscar.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btBuscar.AutoScroll = true;
            this.btBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBuscar.BackgroundImage")));
            this.btBuscar.ButtonText = "Buscar ";
            this.btBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.ForeColor = System.Drawing.Color.Black;
            this.btBuscar.IdleBorderThickness = 1;
            this.btBuscar.IdleCornerRadius = 20;
            this.btBuscar.IdleFillColor = System.Drawing.Color.Transparent;
            this.btBuscar.IdleForecolor = System.Drawing.Color.Black;
            this.btBuscar.IdleLineColor = System.Drawing.Color.Black;
            this.btBuscar.Location = new System.Drawing.Point(578, 50);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(157, 42);
            this.btBuscar.TabIndex = 55;
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.DoubleBuffered = true;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvUsuarios.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvUsuarios.Location = new System.Drawing.Point(11, 91);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsuarios.Size = new System.Drawing.Size(724, 295);
            this.dgvUsuarios.TabIndex = 56;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 395);
            this.Controls.Add(this.paneCentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.paneCentral.ResumeLayout(false);
            this.paneCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel paneCentral;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvUsuarios;
        private Bunifu.Framework.UI.BunifuThinButton2 btBuscar;
    }
}