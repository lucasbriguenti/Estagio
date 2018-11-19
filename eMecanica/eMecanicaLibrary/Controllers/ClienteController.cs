using eMecanicaLibrary.Models;
using eMecanicaLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMecanicaLibrary.Controllers
{
    public class ClienteController
    {
        private EstadoVM getEstado(int id)
        {
            Estado e = new Estado().getEstado(id);
            return new EstadoVM()
            {
                codigo = e.codigo,
                id = e.id,
                nome = e.nome,
                sigla = e.sigla
            };
        }
        public List<EstadoVM> getEstado()
        {
            var dados = new Estado().getEstado();
            if(dados != null && dados.Count>0)
            {
                return (from d in dados
                        select new EstadoVM()
                        {
                            codigo = d.codigo,
                            id = d.id,
                            sigla = d.sigla,
                            nome = d.nome
                        }).ToList();
            }
            return null;
        }
        public List<CidadeVM> getCidade(int idEstado)
        {
            var dados = new Cidade().getCidades(idEstado);
            if(dados!=null && dados.Count>0)
            {
                return (from d in dados
                        select new CidadeVM()
                        {
                            codigo = d.codigo,
                            id = d.id,
                            nome = d.nome
                        }).ToList();
            }
            return null;
        }
    }
}
