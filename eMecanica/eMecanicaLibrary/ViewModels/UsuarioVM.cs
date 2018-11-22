using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMecanicaLibrary.ViewModels
{
    public class UsuarioVM
    {
        public int id { get; set; }
        public int idEndereco { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string email { get; set; }
        public DateTime dtNasc { get; set; }
        public string cep { get; set; }
        public int estado { get; set; }
        public int cidade { get; set; }
        public string rua { get; set; }
        public long num { get; set; }
        public string bairro { get; set; }
        public string complemento { get; set; }
        public string referencia { get; set; }
        public string senha { get; set; }
        public int nivelAcesso { get; set; }
        public string celular { get; set; }
        public string fixo { get; set; }
    }
}
