using eMecanicaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMecanicaLibrary.DAL
{
    internal class CidadeDAO : Banco
    {
        private List<Cidade> tableToList(DataTable dt)
        {
            List<Cidade> dados = null;
            if(dt!=null && dt.Rows.Count>0)
            {
                dados = (from DataRow row in dt.Rows
                         select new Cidade()
                         {
                             codigo = Convert.ToInt32(row["cid_cod"]),
                             id = Convert.ToInt32(row["cid_id"]),
                             nome = row["cid_nome"].ToString()
                         }).ToList();
            }
            return dados;
        }
        private Cidade tableToObject(DataTable dt)
        {
            return new Cidade()
            {
                codigo = Convert.ToInt32(dt.Rows[0]["cid_cod"]),
                id = Convert.ToInt32(dt.Rows[0]["cid_id"]),
                nome = dt.Rows[0]["cid_nome"].ToString()
            };
        }
        internal List<Cidade> getCidades(int id)
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"select * from cidade where est_id=" + id + ";";
            DataTable dt = ExecutaSelect();
            return tableToList(dt);
        }
        internal Cidade getCidade(int id)
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"select * from cidade where cid_id=@cid;";
            ComandoSQL.Parameters.AddWithValue("@cid", id);
            DataTable dt = ExecutaSelect();
            return tableToObject(dt);
        }
    }
}
