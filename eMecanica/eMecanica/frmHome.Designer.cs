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
            this.paneLateral = new System.Windows.Forms.Panel();
            this.paneMeio = new System.Windows.Forms.Panel();
            this.btFechar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btMaximizar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btMinimizar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.paneSuperior.SuspendLayout();
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
            this.paneSuperior.Controls.Add(this.bunifuCustomLabel1);
            this.paneSuperior.Controls.Add(this.btMinimizar);
            this.paneSuperior.Controls.Add(this.btMaximizar);
            this.paneSuperior.Controls.Add(this.btFechar);
            this.paneSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneSuperior.Location = new System.Drawing.Point(0, 0);
            this.paneSuperior.Name = "paneSuperior";
            this.paneSuperior.Size = new System.Drawing.Size(800, 30);
            this.paneSuperior.TabIndex = 0;
            // 
            // paneLateral
            // 
            this.paneLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(189)))));
            this.paneLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneLateral.Location = new System.Drawing.Point(0, 30);
            this.paneLateral.Name = "paneLateral";
            this.paneLateral.Size = new System.Drawing.Size(166, 420);
            this.paneLateral.TabIndex = 1;
            // 
            // paneMeio
            // 
            this.paneMeio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.paneMeio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneMeio.Location = new System.Drawing.Point(166, 30);
            this.paneMeio.Name = "paneMeio";
            this.paneMeio.Size = new System.Drawing.Size(634, 420);
            this.paneMeio.TabIndex = 2;
            // 
            // btFechar
            // 
            this.btFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFechar.AutoSize = true;
            this.btFechar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(189)))));
            this.btFechar.Location = new System.Drawing.Point(769, 0);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(26, 26);
            this.btFechar.TabIndex = 0;
            this.btFechar.Text = "X";
            this.btFechar.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // btMaximizar
            // 
            this.btMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaximizar.AutoSize = true;
            this.btMaximizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMaximizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(189)))));
            this.btMaximizar.Location = new System.Drawing.Point(739, 0);
            this.btMaximizar.Name = "btMaximizar";
            this.btMaximizar.Size = new System.Drawing.Size(24, 26);
            this.btMaximizar.TabIndex = 1;
            this.btMaximizar.Text = "⏍";
            this.btMaximizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMaximizar.Click += new System.EventHandler(this.btMaximizar_Click);
            // 
            // btMinimizar
            // 
            this.btMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimizar.AutoSize = true;
            this.btMinimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(189)))));
            this.btMinimizar.Location = new System.Drawing.Point(711, 0);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(22, 26);
            this.btMinimizar.TabIndex = 2;
            this.btMinimizar.Text = "_";
            this.btMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(189)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 4);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(116, 22);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "eMecanica";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paneMeio);
            this.Controls.Add(this.paneLateral);
            this.Controls.Add(this.paneSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHome";
            this.paneSuperior.ResumeLayout(false);
            this.paneSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel paneMeio;
        private System.Windows.Forms.Panel paneLateral;
        private System.Windows.Forms.Panel paneSuperior;
        private Bunifu.Framework.UI.BunifuCustomLabel btFechar;
        private Bunifu.Framework.UI.BunifuCustomLabel btMinimizar;
        private Bunifu.Framework.UI.BunifuCustomLabel btMaximizar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}