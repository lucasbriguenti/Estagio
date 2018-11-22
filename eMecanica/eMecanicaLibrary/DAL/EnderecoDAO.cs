using eMecanicaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
        private Endereco tableToObject(DataRow row)
        {
            return new Endereco()
            {
                bairro = row["end_bairro"].ToString(),
                cep = row["end_cep"].ToString(),
                cidade = new Cidade().getCidade(Convert.ToInt32(row["cid_id"])),
                complemento = row["end_complemento"].ToString(),
                id = Convert.ToInt32(row["end_id"]),
                numero = Convert.ToInt64(row["end_numero"]),
                referencia = row["end_referencia"].ToString(),
                rua = row["end_rua"].ToString()
            };
        }
        internal Endereco getEndereco(int id)
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"select * from endereco where end_id=@id;";
            ComandoSQL.Parameters.AddWithValue("@id", id);
            DataTable dt = ExecutaSelect();
            if (dt != null && dt.Rows.Count > 0)
                return tableToObject(dt.Rows[0]);
            return null;
        }
    }
}
