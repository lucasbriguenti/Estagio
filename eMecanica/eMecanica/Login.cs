using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eMecanica
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if(side.Width==50)
            {
                side.Visible = false;
                side.Width = 260;
                paneTransation.ShowSync(side);
            }
            else
            {
                side.Visible = false;
                side.Width = 50;
                paneTransation.ShowSync(side);
            }
        }
    }
}
