using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMecanicaLibrary.Models
{
    internal class MaoDeObra
    {
        private int _id;

        internal int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private decimal _valor;

        internal decimal valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        private TimeSpan _tempoMedio;

        internal TimeSpan tempoMedio
        {
            get { return _tempoMedio; }
            set { _tempoMedio = value; }
        }
        private string _descricao;

        internal string descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

    }
}
