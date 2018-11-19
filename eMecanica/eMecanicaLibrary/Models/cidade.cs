using eMecanicaLibrary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMecanicaLibrary.Models
{
    internal class Cidade
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
        private Estado _estado;

        internal Estado estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        private int _cod;

        internal int codigo
        {
            get { return _cod; }
            set { _cod = value; }
        }
        internal List<Cidade> getCidades(int idEstado)
        {
            return new CidadeDAO().getCidades(idEstado);
        }
    }
}
