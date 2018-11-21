using eMecanicaLibrary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMecanicaLibrary.Models
{
    internal class Empresa
    {
        private int _id;

        internal int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _cnpj;

        internal string cnpj
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }
        private string _inscestadual;

        internal string inscEstadual
        {
            get { return _inscestadual; }
            set { _inscestadual = value; }
        }
        private string _inscmunicipal;

        internal string inscMunicipal
        {
            get { return _inscmunicipal; }
            set { _inscmunicipal = value; }
        }
        private string _razaosocial;

        internal string razaoSocial
        {
            get { return _razaosocial; }
            set { _razaosocial = value; }
        }
        private string _nomefantasia;

        internal string nomeFantasia
        {
            get { return _nomefantasia; }
            set { _nomefantasia = value; }
        }
        private Endereco _endereco;

        internal Endereco endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }
        private int _layout;

        internal int layout
        {
            get { return _layout; }
            set { _layout = value; }
        }
        private string _logo;

        internal string logo
        {
            get { return _logo; }
            set { _logo = value; }
        }
        private string _telefone1;

        internal string telefone1
        {
            get { return _telefone1; }
            set { _telefone1 = value; }
        }
        private string _telefone2;

        internal string telefone2
        {
            get { return _telefone2; }
            set { _telefone2 = value; }
        }
        internal bool gravar()
        {
            return new EmpresaDAO().gravar(this);
        }
    }
}
