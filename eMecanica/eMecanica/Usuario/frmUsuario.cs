using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mod = eMecanicaLibrary.ViewModels;
using con = eMecanicaLibrary.Controllers;
namespace eMecanica.Usuario
{
    public partial class frmUsuario : Form
    {
        private con.UsuarioController controller;
        public frmUsuario()
        {
            InitializeComponent();
            controller = new con.UsuarioController();
            carregaDgv();
        }
        private void carregaDgv(string nome="")
        {
            List<mod.UsuarioVM> list;
            if(nome=="")
            {
                list = controller.getUsuario();
            }
            else
            {
                list = controller.getUsuario(nome);
            }
            dgvUsuarios.DataSource = list;
            dgvUsuarios.Focus();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if(txtBusca.Text!=String.Empty)
            {

            }
        }
    }
}
