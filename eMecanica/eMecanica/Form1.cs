using eMecanica.Models;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var context = new Context();
            cidade c = new cidade()
            {
                cid_nome = "niteroi",
                est_id = 2,
                cid_cod = "saswe21312"
            };
            context.cidade.Add(c);
            context.SaveChanges();
            estado est = context.estado.Where(a=>a.est_id==2).Single();
            string str = est.est_nome+"\n";
            foreach (cidade e in est.cidade)
                str += e.cid_nome + "\n";
            MessageBox.Show(str);
        }
    }
}
