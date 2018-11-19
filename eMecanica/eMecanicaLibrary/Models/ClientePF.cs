using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMecanicaLibrary.Models
{
    internal class ClientePF : Cliente
    {
        private DateTime dtnasc;

        internal DateTime dataNascimento
        {
            get { return dtnasc; }
            set { dtnasc = value; }
        }
        private string _cpf;

        internal string cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
        private string _rg;

        internal string rg
        {
            get { return _rg; }
            set { _rg = value; }
        }
        private char _sexo;

        internal char sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

    }
}
