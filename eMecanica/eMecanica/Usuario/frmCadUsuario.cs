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
        private con.UsuarioController controller;
        public frmCadUsuario()
        {
            InitializeComponent();
            controller = new con.UsuarioController();
            txtId.Text = "0";
            txtIdEndereco.Text = "0";
            cbbNivel.Items.Add("Secretária");
            cbbNivel.Items.Add("Mecânico");
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
            }
            txtNome.Focus();
        }
        #region validador de campos

        
        private List<string> validaCampos()
        {
            List<string> list = new List<string>();
            if (txtBairro.Text.Trim() == String.Empty)
            {
                list.Add("Bairro");
                lbBairro.BackColor = Color.Red;
            }
            if (txtCep.Text.Trim() == String.Empty)
            {
                list.Add("CEP");
                lbCep.BackColor = Color.Red;
            }
            if (txtCpf.Text.Trim() == String.Empty)
            {
                list.Add("CPF");
                lbCpf.BackColor = Color.Red;
            }
            if (txtEmail.Text.Trim() == String.Empty || !txtEmail.Text.Contains("@"))
            {
                list.Add("Email");
                lbEmail.BackColor = Color.Red;
            }
            if (txtNome.Text.Trim() == String.Empty)
            {
                list.Add("Nome");
                lbNome.BackColor = Color.Red;
            }
            if (txtNum.Text.Trim() == String.Empty)
            {
                list.Add("Número");
                lbNum.BackColor = Color.Red;
            }
            if (txtRg.Text.Trim() == String.Empty)
            {
                list.Add("RG");
                lbRg.BackColor = Color.Red;
            }
            if (txtSenha.Text.Trim() == String.Empty || txtSenha.Text.Length < 6)
            {
                list.Add("Senha");
                lbSenha.BackColor = Color.Red;
            }
            if (txtTelCelular.Text.Trim() == String.Empty)
            {
                list.Add("Telefone Celular");
                lbCelular.BackColor = Color.Red;
            }
            if(cbbCidade.SelectedIndex==-1)
            {
                list.Add("Cidade");
                lbCidade.BackColor = Color.Red;
            }
            if (cbbEstado.SelectedIndex == -1)
            {
                list.Add("Estado");
                lbEstado.BackColor = Color.Red;
            }
            return list;
        }
        #endregion
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

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            List<string> list = validaCampos();
            if(list.Count==0)
            {
                mod.UsuarioVM usu = new mod.UsuarioVM()
                {
                    bairro = txtBairro.Text,
                    celular = txtTelCelular.Text,
                    cep = txtCep.Text,
                    cidade = Convert.ToInt32(cbbCidade.SelectedValue),
                    complemento = txtComplemento.Text,
                    cpf = txtCpf.Text,
                    dtNasc = dtDataNasc.Value.Date,
                    email = txtEmail.Text,
                    estado = Convert.ToInt32(cbbEstado.SelectedValue),
                    fixo = txtTelFixo.Text,
                    id = Convert.ToInt32(txtId.Text),
                    idEndereco = Convert.ToInt32(txtIdEndereco.Text),
                    nivelAcesso = cbbNivel.SelectedItem.ToString() == "Secretária" ? 1 : 2,
                    nome = txtNome.Text,
                    num = Convert.ToInt64(txtNum.Text),
                    referencia = txtReferencia.Text,
                    rg = txtRg.Text,
                    rua = txtRua.Text,
                    senha = txtSenha.Text
                };
                if (controller.gravar(usu))
                {
                    MessageBox.Show(this, "Usuário gravado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                    MessageBox.Show(this, "Erro na gravação do Usuário", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string err = "Campos inválidos\n";
                bool linha = true ;
                foreach(string s in list)
                {
                    if(!linha)
                        err += "*" + s + "\n";
                    else
                        err += "*" + s+"           ";
                    linha = !linha;
                }
                lbErro.Visible = true;
                lbErro.Text = err;
            }
        }
    }
}
