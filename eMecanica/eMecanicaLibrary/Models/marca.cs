using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMecanicaLibrary.Models
{
    internal class Marca
    {
        private int _id;

        internal int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nome;

        internal string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private string _logo;

        internal string logo
        {
            get { return _logo; }
            set { _logo = value; }
        }

    }
}
