using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMecanicaLibrary.ViewModels
{
    public class EmpresaVM
    {
        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nomeFantasia;

        public string nomeFantasia
        {
            get { return _nomeFantasia; }
            set { _nomeFantasia = value; }
        }
        private string _razaoSocial;

        public string razaoSocial
        {
            get { return _razaoSocial; }
            set { _razaoSocial = value; }
        }
        private string _inscEstadual;

        public string inscEstadual
        {
            get { return _inscEstadual; }
            set { _inscEstadual = value; }
        }
        private string _inscMunic;

        public string inscMunicipal
        {
            get { return _inscMunic; }
            set { _inscMunic = value; }
        }
        private string _cnpj;

        public string cnpj
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }
        private string _cep;

        public string cep
        {
            get { return _cep; }
            set { _cep = value; }
        }
        private int _estado;

        public int estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        private int _cidade;

        public int cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }
        private string _rua;

        public string rua
        {
            get { return _rua; }
            set { _rua = value; }
        }
        private int _numero;

        public int numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        private string _bairro;

        public string bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }
        private string _referencia;

        public string referencia
        {
            get { return _referencia; }
            set { _referencia = value; }
        }
        private string _complemento;

        public string complemento
        {
            get { return _complemento; }
            set { _complemento = value; }
        }
        private string _logo;

        public string logo
        {
            get { return _logo; }
            set { _logo = value; }
        }
        private int _layout;

        public int layout
        {
            get { return _layout; }
            set { _layout = value; }
        }

        private string _tel1;

        public string telefone1
        {
            get { return _tel1; }
            set { _tel1 = value; }
        }
        private string _tel2;

        public string telefone2
        {
            get { return _tel2; }
            set { _tel2 = value; }
        }
        public int idEndereco { get; set; }
    }
}
