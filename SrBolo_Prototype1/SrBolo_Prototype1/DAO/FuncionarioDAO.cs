using System;
using System.Data;
using Npgsql;
using SrBolo_Prototype1.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrBolo_Prototype1.DAO
{
    class FuncionarioDAO : ClassConexao
    {
        DataTable Dt = new DataTable();

        public DataTable funcionariosCadastrados()
        {
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("ListarFunc", Cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Dr = Cmd.ExecuteReader();
                Dt.Load(Dr);
            }

            catch (Exception e)
            {
                throw new Exception("erro ao acessar os funcionários" + e.Message);
            }
            finally {
                Desconectar();
            
            }
            return Dt;
        }


    }
}
