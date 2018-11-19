using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMecanicaLibrary.Models
{
    internal class ClientePJ : Cliente
    {
        private string _cnpj;

        internal string cnpj
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }
        private string inscestadual;

        internal string inscEstadual
        {
            get { return inscestadual; }
            set { inscestadual = value; }
        }
        private string inscmunicipal;

        internal string inscMunicipal
        {
            get { return inscmunicipal; }
            set { inscmunicipal = value; }
        }
        private string _razaosocial;

        internal string razaoSocial
        {
            get { return _razaosocial; }
            set { _razaosocial = value; }
        }
        private string _nome;

        internal string nomeFantasia
        {
            get { return _nome; }
            set { _nome = value; }
        }

    }
}
