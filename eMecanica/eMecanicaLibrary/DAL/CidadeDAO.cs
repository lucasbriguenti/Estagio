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
        internal List<Cidade> getCidades(int id)
        {
            ComandoSQL.Parameters.Clear();
            ComandoSQL.CommandText = @"select * from cidade where est_id=" + id + ";";
            DataTable dt = ExecutaSelect();
            return tableToList(dt);
        }
    }
}
