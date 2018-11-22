using eMecanicaLibrary.Models;
using eMecanicaLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMecanicaLibrary.Controllers
{
    public class UsuarioController
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
        public bool gravar(UsuarioVM usu)
        {
            Endereco end = new Endereco()
            {
                bairro = usu.bairro,
                cep = usu.cep,
                cidade = new Cidade().getCidade(usu.cidade),
                complemento = usu.complemento,
                id = usu.idEndereco,
                numero = usu.num,
                referencia = usu.referencia,
                rua = usu.rua
            };
            Usuario u = new Usuario()
            {
                id = usu.id,
                celular = usu.celular,
                cpf = usu.cpf,
                dataNascimento = usu.dtNasc,
                email = usu.email,
                endereco = end,
                nivelAcesso = usu.nivelAcesso,
                nome = usu.nome,
                rg = usu.rg,
                senha = usu.senha,
                telefoneFixo = usu.fixo
            };
            return u.gravar();
        }
        public bool excluir(int id)
        {
            return new Usuario().excluir(id);
        }
        public List<UsuarioVM> getUsuario(string nome)
        {
            var dados = new Usuario().getUsuario(nome);
            if(dados!=null && dados.Count>0)
            {
                return (from u in dados
                        select new UsuarioVM()
                        {
                            bairro = u.endereco.bairro,
                            celular = u.celular,
                            cep = u.endereco.cep,
                            cidade = u.endereco.cidade.id,
                            id = u.id,
                            complemento = u.endereco.complemento,
                            cpf = u.cpf,
                            dtNasc = u.dataNascimento,
                            email = u.email,
                            estado = u.endereco.cidade.estado.id,
                            fixo = u.telefoneFixo,
                            idEndereco = u.endereco.id,
                            nivelAcesso = u.nivelAcesso,
                            nome = u.nome,
                            num = u.endereco.numero,
                            referencia = u.endereco.referencia,
                            rg = u.rg,
                            rua = u.endereco.rua,
                            senha = u.senha
                        }).ToList();
            }
            return null;
        }
        public UsuarioVM getUsuario(int id)
        {
            Usuario u = new Usuario().getUsuario(id);
            if(u!=null)
            {
                return new UsuarioVM()
                {
                    bairro = u.endereco.bairro,
                    celular = u.celular,
                    cep = u.endereco.cep,
                    cidade = u.endereco.cidade.id,
                    id = u.id,
                    complemento = u.endereco.complemento,
                    cpf = u.cpf,
                    dtNasc = u.dataNascimento,
                    email = u.email,
                    estado = u.endereco.cidade.estado.id,
                    fixo = u.telefoneFixo,
                    idEndereco = u.endereco.id,
                    nivelAcesso = u.nivelAcesso,
                    nome = u.nome,
                    num = u.endereco.numero,
                    referencia = u.endereco.referencia,
                    rg = u.rg,
                    rua = u.endereco.rua,
                    senha = u.senha
                };
            }
            return null;
            
        }
    }
}
