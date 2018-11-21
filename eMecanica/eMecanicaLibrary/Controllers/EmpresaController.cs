using eMecanicaLibrary.Models;
using eMecanicaLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMecanicaLibrary.Controllers
{
    public class EmpresaController
    {
        public bool gravar(EmpresaVM emp)
        {
            Endereco end = new Endereco()
            {
                bairro = emp.bairro,
                cep = emp.cep,
                cidade = new Cidade().getCidade(emp.cidade),
                complemento = emp.complemento,
                id = emp.idEndereco,
                numero = emp.numero,
                referencia = emp.referencia,
                rua = emp.rua
            };
            Empresa e = new Empresa()
            {
                id = emp.id,
                cnpj = emp.cnpj,
                endereco = end,
                inscEstadual = emp.inscEstadual,
                inscMunicipal = emp.inscMunicipal,
                layout = emp.layout,
                logo = emp.logo,
                nomeFantasia = emp.nomeFantasia,
                razaoSocial = emp.razaoSocial,
                telefone1 = emp.telefone1,
                telefone2 = emp.telefone2
            };
            return e.gravar();
        }
        public List<EstadoVM> getEstado()
        {
            var dados = new Estado().getEstado();
            if (dados != null && dados.Count > 0)
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
            if (dados != null && dados.Count > 0)
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
