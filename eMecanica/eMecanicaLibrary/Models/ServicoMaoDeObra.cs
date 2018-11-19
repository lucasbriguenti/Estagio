using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMecanicaLibrary.Models
{
    internal class ServicoMaoDeObra
    {
        private int id_maodeobra;

        internal int idMaoDeObra
        {
            get { return id_maodeobra; }
            set { id_maodeobra = value; }
        }
        private int id_servico;

        internal int idServico
        {
            get { return id_servico; }
            set { id_servico = value; }
        }
        private decimal _valor;

        internal decimal valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        private decimal _desconto;

        internal decimal desconto
        {
            get { return _desconto; }
            set { _desconto = value; }
        }

    }
}
