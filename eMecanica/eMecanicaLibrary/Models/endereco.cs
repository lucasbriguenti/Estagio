using eMecanicaLibrary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMecanicaLibrary.Models
{
    internal class Endereco
    {
        private int _id;

        internal int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _rua;

        internal string rua
        {
            get { return _rua; }
            set { _rua = value; }
        }
        private int _numero;

        internal int numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        private string _bairro;

        internal string bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }
        private string _complemento;

        internal string complemento
        {
            get { return _complemento; }
            set { _complemento = value; }
        }
        private string _referencia;

        internal string referencia
        {
            get { return _referencia; }
            set { _referencia = value; }
        }
        private Cidade _cidade;

        internal Cidade cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }
        private string _cep;

        internal string cep
        {
            get { return _cep; }
            set { _cep = value; }
        }
        internal int gravar(Endereco e)
        {
            return new EnderecoDAO().gravar(e);
        }
    }
}
