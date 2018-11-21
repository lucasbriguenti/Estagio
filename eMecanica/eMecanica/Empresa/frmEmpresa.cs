using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using con = eMecanicaLibrary.Controllers;
using mod = eMecanicaLibrary.ViewModels;

namespace eMecanica.Empresa
{
    public partial class frmEmpresa : Form
    {
        private con.EmpresaController controller;
        public frmEmpresa()
        {
            InitializeComponent();
            controller = new con.EmpresaController();
            carregaCbb();
            txtIdEmpresa.Text = "0";
            txtIdEndereco.Text = "0";
        }
        private void carregaCbb()
        {
            cbbEstado.ValueMember = "id";
            cbbEstado.DisplayMember = "nome";
            List<mod.EstadoVM> list = controller.getEstado();
            cbbEstado.DataSource = list;
        }

        #region Validador de Campos

       
        private List<string> validaCampos()
        {
            List<string> list = new List<string>();
            if(txtBairro.Text.Trim()==String.Empty)
            {
                list.Add("Bairro");
                lbBairro.BackColor = Color.Red;
            }
            if (txtCep.Text.Trim() == String.Empty)
            {
                list.Add("CEP");
                lbCep.BackColor = Color.Red;
            }
            if (txtCnpj.Text.Trim() == String.Empty)
            {
                list.Add("CNPJ");
                lbCnpj.BackColor = Color.Red;
            }
            if (txtInscEstadual.Text.Trim() == String.Empty)
            {
                list.Add("Inscrição Estadual");
                lbInscEst.BackColor = Color.Red;
            }
            if (txtInscMunicipal.Text.Trim() == String.Empty)
            {
                list.Add("Inscrição Municipal");
                lbInscMun.BackColor = Color.Red;
            }
            if (txtNome.Text.Trim() == String.Empty)
            {
                list.Add("Nome Fantasia");
                lbNome.BackColor = Color.Red;
            }
            if (txtNumero.Text.Trim() == String.Empty)
            {
                list.Add("Número");
                lbNumero.BackColor = Color.Red;
            }
            if (txtRazao.Text.Trim() == String.Empty)
            {
                list.Add("Razão Social");
                lbRazao.BackColor = Color.Red;
            }
            if (txtRua.Text.Trim() == String.Empty)
            {
                list.Add("Rua");
                lbRua.BackColor = Color.Red;
            }
            if (txtTelefone2.Text.Trim() == String.Empty)
            {
                list.Add("Telefone Fixo");
                lbFixo.BackColor = Color.Red;
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
        private void btFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private string copyImage()
        {
            string destino = "\\imagem\\logo.png";
            var arquivos = Directory.GetFiles("\\imagem", ".png", SearchOption.AllDirectories);
            if(arquivos.Contains("logo.png"))
            {
                File.Copy(pictureBox1.ImageLocation, destino);
            }
            return destino;
        }
        private void btGravar_Click_1(object sender, EventArgs e)
        {
            List<string> erros = validaCampos();
            if (erros.Count == 0)
            {
                mod.EmpresaVM empresa = new mod.EmpresaVM()
                {
                    bairro = txtBairro.Text,
                    cep = txtCep.Text,
                    cidade = Convert.ToInt32(cbbCidade.SelectedValue),
                    cnpj = txtCnpj.Text,
                    complemento = txtComplemento.Text,
                    estado = Convert.ToInt32(cbbEstado.SelectedValue),
                    id = Convert.ToInt32(txtIdEmpresa.Text),
                    idEndereco = Convert.ToInt32(txtIdEndereco.Text),
                    inscEstadual = txtInscEstadual.Text,
                    inscMunicipal = txtInscMunicipal.Text,
                    logo=pictureBox1.ImageLocation=="" ? "" :copyImage(),
                    layout = 1,
                    nomeFantasia = txtNome.Text,
                    numero = Convert.ToInt32(txtNumero.Text),
                    razaoSocial = txtRazao.Text,
                    referencia = txtReferencia.Text,
                    rua = txtRua.Text,
                    telefone1 = txtTelefone1.Text,
                    telefone2 = txtTelefone2.Text
                };
                if (controller.gravar(empresa))
                {
                    MessageBox.Show(this, "Gravado com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Ocorreu um erro na gravação", "Informacao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string err = "Campos inválidos\n";
                foreach (string str in erros)
                {
                    err += "*" + str + "\n";
                }
                lbErro.Text = err;
                lbErro.Visible = true;
            }
        }

        private void btLimpar_Click_1(object sender, EventArgs e)
        {
            foreach (Control con in paneCentral.Controls)
            {
                if (con is TextBox || con is MaskedTextBox)
                    con.Text = "";
                if (con is ComboBox)
                {
                    ComboBox aux = con as ComboBox;
                    aux.SelectedIndex = -1;
                }
            }
            txtRazao.Focus();
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

        private void lbRazao_Click(object sender, EventArgs e)
        {

        }

        private void txtRazao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbNome_Click(object sender, EventArgs e)
        {

        }

        private void lbInscEst_Click(object sender, EventArgs e)
        {

        }

        private void txtInscEstadual_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInscMunicipal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbInscMun_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefone1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lbCelular_Click(object sender, EventArgs e)
        {

        }

        private void txtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btBuscaCep_Click(object sender, EventArgs e)
        {

        }

        private void cbbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbCep_Click(object sender, EventArgs e)
        {

        }

        private void lbCidade_Click(object sender, EventArgs e)
        {

        }

        private void txtCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtTelefone2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lbFixo_Click(object sender, EventArgs e)
        {

        }

        private void lbCnpj_Click(object sender, EventArgs e)
        {

        }

        private void lbEstado_Click(object sender, EventArgs e)
        {

        }

        private void lbRua_Click(object sender, EventArgs e)
        {

        }

        private void lbBairro_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel13_Click(object sender, EventArgs e)
        {

        }

        private void txtReferencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRua_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbNumero_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel12_Click(object sender, EventArgs e)
        {

        }

        private void btLogo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imagens|*png;*jpg;*jpeg";
           if(openFileDialog1.ShowDialog()==DialogResult.OK)
           {
                FileInfo file = new FileInfo(openFileDialog1.FileName);
                if(file.Length<= 1048576)
                    pictureBox1.ImageLocation = openFileDialog1.FileName;
                else
                {
                    lbErro.Visible = true;
                    lbErro.Text = "Imagem maior que 1MB!";
                }
           }
        }

        private void btLayout_Click(object sender, EventArgs e)
        {

        }

        private void txtIdEmpresa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
