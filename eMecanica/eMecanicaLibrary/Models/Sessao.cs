using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMecanicaLibrary.Models
{
    internal class Sessao
    {
        private Usuario us;

        internal Usuario usuario
        {
            get { return us; }
            set { us = value; }
        }

    }
}
