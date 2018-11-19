using eMecanicaLibrary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMecanicaLibrary.Models
{
    internal class Estado
    {
        private int _id;

        internal int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _cod;

        internal int codigo
        {
            get { return _cod; }
            set { _cod = value; }
        }
        private string _nome;

        internal string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private string _sigla;

        internal string sigla
        {
            get { return _sigla; }
            set { _sigla = value; }
        }
        internal List<Estado> getEstado()
        {
            return new EstadoDAO().getEstado();
        }
        internal Estado getEstado(int id)
        {
            return new EstadoDAO().getEstado(id);
        }
    }
}
