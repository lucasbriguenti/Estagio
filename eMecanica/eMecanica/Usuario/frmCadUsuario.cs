using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using con = eMecanicaLibrary.Controllers;
using mod = eMecanicaLibrary.ViewModels;

namespace eMecanica.Usuario
{
    public partial class frmCadUsuario : Form
    {
        private con.ClienteController controller = new con.ClienteController();
        public frmCadUsuario()
        {
            InitializeComponent();
            cbbNivel.Items.Add("Nível 1");
            cbbNivel.Items.Add("Nível 2");
            carregaCbb();
        }
        private void carregaCbb()
        {
            cbbEstado.ValueMember = "id";
            cbbEstado.DisplayMember = "nome";
            List<mod.EstadoVM> list = controller.getEstado();
            cbbEstado.DataSource = list;
        }
        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cbbNivel_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Nível 1 Acesso total\nNível 2 Acesso Restrito",cbbNivel);
        }

        private void ocultarFoto_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !txtSenha.UseSystemPasswordChar;
        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }
        private void limpaCbb(ComboBox cbb)
        {
            cbb.SelectedIndex = -1;
        }
        private void limpaDatePicker(DateTimePicker dt)
        {
            dt.Value = DateTime.Now;
        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            foreach(Control con in paneCentral.Controls)
            {
                if (con is TextBox || con is MaskedTextBox)
                    con.Text = "";
                if(con is ComboBox)
                {
                    limpaCbb((ComboBox)con);
                }
                if(con is DateTimePicker)
                {
                    limpaDatePicker((DateTimePicker)con);
                }
            }
            txtNome.Focus();
        }

        private void cbbEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbbEstado.SelectedIndex != -1)
            {
                int id = (int)cbbEstado.SelectedValue;
                List<mod.CidadeVM> list = controller.getCidade(id);
                cbbCidade.ValueMember = "id";
                cbbCidade.DisplayMember = "nome";
                cbbCidade.DataSource = list;
            }
            
        }

    }
}
