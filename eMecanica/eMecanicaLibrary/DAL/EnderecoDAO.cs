using eMecanicaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMecanicaLibrary.DAL
{
    internal class EnderecoDAO : Banco
    {
        internal int gravar(Endereco e)
        {
            int retorno = 0;
            ComandoSQL.Parameters.Clear();
            if (e.id==0)
            {
                ComandoSQL.CommandText = @"insert into endereco (end_rua,end_numero,end_bairro,end_complemento,end_referencia,cid_id,end_cep)
                                     values(@rua,@num,@bairro,@comp,@refer,@cid,@cep);";
                ComandoSQL.Parameters.AddWithValue("@rua", e.rua);
                ComandoSQL.Parameters.AddWithValue("@num", e.numero);
                ComandoSQL.Parameters.AddWithValue("@bairro", e.bairro);
                ComandoSQL.Parameters.AddWithValue("@comp", e.complemento);
                ComandoSQL.Parameters.AddWithValue("@refer", e.referencia);
                ComandoSQL.Parameters.AddWithValue("@cid", e.cidade.id);
                ComandoSQL.Parameters.AddWithValue("@cep", e.cep);
                ExecutaComando(out retorno);
                return retorno;
            }
            else
            {
                ComandoSQL.CommandText = @"update endereco set end_rua=@rua,end_numero=@num,end_bairro=@bairro,end_complemento=@comp,
                                        end_referencia=@refer,cid_id=@cid,end_cep=@cep where end_id=@id;";
                ComandoSQL.Parameters.AddWithValue("@rua", e.rua);
                ComandoSQL.Parameters.AddWithValue("@num", e.numero);
                ComandoSQL.Parameters.AddWithValue("@bairro", e.bairro);
                ComandoSQL.Parameters.AddWithValue("@comp", e.complemento);
                ComandoSQL.Parameters.AddWithValue("@refer", e.referencia);
                ComandoSQL.Parameters.AddWithValue("@cid", e.cidade.id);
                ComandoSQL.Parameters.AddWithValue("@cep", e.cep);
                ComandoSQL.Parameters.AddWithValue("@id", e.id);
                ExecutaComando();
                return e.id;
            }
            
            
        }
    }
}
