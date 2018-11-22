using eMecanicaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMecanicaLibrary.DAL
{
    internal class UsuarioDAO : Banco
    {
        internal bool gravar(Usuario usu)
        {
            ComandoSQL.Parameters.Clear();
            int idEndereco = usu.endereco.gravar();
            if(usu.id==0)
                ComandoSQL.CommandText = @"insert into usuario (end_id,usu_nome,usu_email,usu_senha,usu_nivelacesso,
                                    usu_rg,usu_cpf,usu_telfixo,usu_dtnasc,usu_celular)
                                    values(@end,@nome,@email,@senha,@nivel,@rg,@cpf,@fixo,@dtnasc,@cel);";
            else
            {
                ComandoSQL.CommandText = @"update usuario set end_id=@end,usu_nome=@nome,usu_email=@email,usu_senha=@senha,@usu_nivelacesso=@nivel,
                                    usu_rg=@rg,usu_cpf=@cpf,usu_telfixo=@fixo,usu_dtnasc=@dtnasc,usu_celular=@cel where usu_id=@id;";
                ComandoSQL.Parameters.AddWithValue("@id", usu.id);
            }
            ComandoSQL.Parameters.AddWithValue("@end", idEndereco);
            ComandoSQL.Parameters.AddWithValue("@nome", usu.nome);
            ComandoSQL.Parameters.AddWithValue("@email", usu.email);
            ComandoSQL.Parameters.AddWithValue("@senha", usu.senha);
            ComandoSQL.Parameters.AddWithValue("@nivel", usu.nivelAcesso);
            ComandoSQL.Parameters.AddWithValue("@rg", usu.rg);
            ComandoSQL.Parameters.AddWithValue("@cpf", usu.cpf);
            ComandoSQL.Parameters.AddWithValue("@fixo", usu.telefoneFixo);
            ComandoSQL.Parameters.AddWithValue("@dtnasc", usu.dataNascimento);
            ComandoSQL.Parameters.AddWithValue("@cel", usu.celular);
            return ExecutaComando() > 0;
        }
        internal bool excluir(int id)
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"delete from usuario where usu_id=@id;";
            ComandoSQL.Parameters.AddWithValue("@id", id);
            return ExecutaComando() > 0;
        }
        private Usuario tableToObject(DataRow row)
        {
            return new Usuario()
            {
                celular = row["usu_celular"].ToString(),
                cpf = row["usu_cpf"].ToString(),
                dataNascimento = Convert.ToDateTime(row["usu_dtnasc"]),
                email = row["usu_email"].ToString(),
                endereco = new Endereco().getEndereco(Convert.ToInt32(row["end_id"])),
                id = Convert.ToInt32(row["usu_id"]),
                nivelAcesso = Convert.ToInt32(row["usu_nivelacesso"]),
                nome = row["usu_nome"].ToString(),
                rg = row["usu_rg"].ToString(),
                senha = row["usu_senha"].ToString(),
                telefoneFixo = row["usu_telfixo"].ToString()
            };
        }
        private List<Usuario> tableToList(DataTable dt)
        {
            List<Usuario> list = new List<Usuario>();
            foreach(DataRow row in dt.Rows)
            {
                list.Add(tableToObject(row));
            }
            return list;
        }
        internal Usuario getUsuario(int id)
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"select * from usuario where usu_id=@id;";
            ComandoSQL.Parameters.AddWithValue("@id", id);
            DataTable dt = ExecutaSelect();
            if (dt != null && dt.Rows.Count > 0)
                return tableToObject(dt.Rows[0]);
            return null;
        }
        internal List<Usuario> getUsuario(string nome)
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"select * from usuario where usu_nome like %@nome%;";
            ComandoSQL.Parameters.AddWithValue("@nome", nome);
            DataTable dt = ExecutaSelect();
            if (dt != null && dt.Rows.Count > 0)
                return tableToList(dt);
            return null;
        }

    }
}
