using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMecanicaLibrary.Models
{
    internal class Usuario
    {
        private int _id;

        internal int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private Endereco _end;

        internal Endereco endereco
        {
            get { return _end; }
            set { _end = value; }
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
        private string _senha;

        internal string senha
        {
            get { return _senha; }
            set { _senha = value; }
        }
        private char _nivel;

        internal char nivelAcesso
        {
            get { return _nivel; }
            set { _nivel = value; }
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
        private string _fixo;

        internal string telefoneFixo
        {
            get { return _fixo; }
            set { _fixo = value; }
        }
        private string _cel;

        internal string celular
        {
            get { return _cel; }
            set { _cel = value; }
        }
        private DateTime dtnasc;

        internal DateTime dataNascimento
        {
            get { return dtnasc; }
            set { dtnasc = value; }
        }

    }
}
