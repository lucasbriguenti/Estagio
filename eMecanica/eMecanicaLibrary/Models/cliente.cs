using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMecanicaLibrary.Models
{
    internal abstract class Cliente
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
        private string _email;

        internal string email
        {
            get { return _email; }
            set { _email = value; }
        }
        private Endereco _endereco;

        internal Endereco endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }
        private string _celular;

        internal string celular
        {
            get { return _celular; }
            set { _celular = value; }
        }
        private string _fixo;

        internal string telefoneFixo
        {
            get { return _fixo; }
            set { _fixo = value; }
        }

    }
}
