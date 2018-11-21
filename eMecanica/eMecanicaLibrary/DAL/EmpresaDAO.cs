using eMecanicaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMecanicaLibrary.DAL
{
    internal class EmpresaDAO : Banco
    {
        internal bool gravar(Empresa emp)
        {
            ComandoSQL.Parameters.Clear();
            int idEndereco = emp.endereco.gravar(),retorno;
            if(emp.id==0)
                ComandoSQL.CommandText = @"insert into empresa (emp_id,emp_cnpj,emp_inscestadual,emp_inscmunicipal,emp_razaosocial,emp_telefone1,emp_telefone2,end_id,emp_layout,emp_logo,emp_nomefantasia)
                                        values (1,@cnpj,@inscEst,@inscMun,@razao,@tel1,@tel2,@end,@layo,@logo,@nome);";  
            else
                ComandoSQL.CommandText = @"update empresa set emp_cnpj=@cnpj,emp_inscestadual=@inscEst,emp_inscmunicipal=@inscMun,emp_razaosocial=@razao,
                                        emp_telefone1=@tel1,emp_telefone2=@tel2,emp_layout=@layo,emp_logo=@logo,emp_nomefantasia=@nome where=emp_id=1;";
            ComandoSQL.Parameters.AddWithValue("@cnpj", emp.cnpj);
            ComandoSQL.Parameters.AddWithValue("@inscEst", emp.inscEstadual);
            ComandoSQL.Parameters.AddWithValue("@inscMun", emp.inscMunicipal);
            ComandoSQL.Parameters.AddWithValue("@razao", emp.razaoSocial);
            ComandoSQL.Parameters.AddWithValue("@tel1", emp.telefone1);
            ComandoSQL.Parameters.AddWithValue("@tel2", emp.telefone2);
            ComandoSQL.Parameters.AddWithValue("@end", idEndereco);
            ComandoSQL.Parameters.AddWithValue("@layo", emp.layout);
            ComandoSQL.Parameters.AddWithValue("@logo", emp.logo);
            ComandoSQL.Parameters.AddWithValue("@nome", emp.nomeFantasia);
            retorno = ExecutaComando();
            return retorno > 0;
        }
    }
}
