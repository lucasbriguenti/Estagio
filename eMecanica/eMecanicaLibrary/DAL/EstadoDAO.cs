using eMecanicaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMecanicaLibrary.DAL
{
    internal class EstadoDAO : Banco
    {
        private List<Estado> tableToList(DataTable dt)
        {
            List<Estado> dados = null;
            if(dt!=null && dt.Rows.Count>0)
            {
                dados = (from DataRow row in dt.Rows
                         select new Estado()
                         {
                             codigo = Convert.ToInt32(row["est_cod"]),
                             id = Convert.ToInt32(row["est_id"]),
                             nome = row["est_nome"].ToString(),
                             sigla = row["est_sigla"].ToString()
                         }).ToList();
            }
            return dados;
        }
        internal List<Estado> getEstado()
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"select * from estado;";
            DataTable dt = ExecutaSelect();
            return tableToList(dt);
        }
        internal Estado getEstado(int id)
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"select * from estado where est_id=" + id + ";";
            DataTable dt = ExecutaSelect();
            if (dt != null)
                return new Estado()
                {
                    codigo = Convert.ToInt32(dt.Rows[0]["est_cod"]),
                    id = Convert.ToInt32(dt.Rows[0]["est_id"]),
                    nome = dt.Rows[0]["est_nome"].ToString(),
                    sigla = dt.Rows[0]["est_sigla"].ToString()
                };
            return null;
        }
    }
}
