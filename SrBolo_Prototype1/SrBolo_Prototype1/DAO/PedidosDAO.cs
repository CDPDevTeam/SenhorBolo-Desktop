using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SrBolo_Prototype1.Model;
using System.Data;
using Npgsql;

namespace SrBolo_Prototype1.DAO
{
    class PedidosDAO : ClassConexao
    {
        DataTable Dt = new DataTable();
        public DataTable pedidosECadastrados()
        {
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("ListarPedE", Cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Dr = Cmd.ExecuteReader();
                Dt.Load(Dr);
            }

            catch (Exception e)
            {
                throw new Exception("erro ao acessar os pedidos" + e.Message);
            }
            finally
            {
                Desconectar();

            }
            return Dt;
        }

        public DataTable pedidosCadastrados()
        {
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("ListarPed", Cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Dr = Cmd.ExecuteReader();
                Dt.Load(Dr);
            }

            catch (Exception e)
            {
                throw new Exception("erro ao acessar os pedidos" + e.Message);
            }
            finally
            {
                Desconectar();

            }
            return Dt;
        }
    }
}
