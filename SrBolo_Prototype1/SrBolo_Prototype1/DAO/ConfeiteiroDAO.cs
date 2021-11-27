using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using SrBolo_Prototype1.common;
using System.Windows.Forms;
using SrBolo_Prototype1.Model;

namespace SrBolo_Prototype1.DAO
{
    class ConfeiteiroDAO : ClassConexao
    {
        public int getNumPedidos()
        {
            int countPeds = 0;
            try
            {
                Conectar();

                NpgsqlCommand Cmd = new NpgsqlCommand("getnumpedidos", Cn); //Procedure do login
                Cmd.CommandType = CommandType.StoredProcedure;
                countPeds = Convert.ToInt32(Cmd.ExecuteScalar());

            }
            catch (Exception e) { MessageBox.Show(e.Message, "ERRO"); }
            finally { Desconectar(); }
            return countPeds;
        }

        DataTable Dt = new DataTable();
        public DataTable getPedidosRecebidos()
        {
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("getPedidosRecebidos", Cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Dr = Cmd.ExecuteReader();
                Dt.Load(Dr);
            }
            catch (Exception e)
            {
                throw new Exception("erro ao acessar os produtos" + e.Message);
            }
            finally
            {
                Desconectar();
            }
            return Dt;
        }

        public DataTable getPedidosaCaminho()
        {
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("getPedidosaCaminho", Cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Dr = Cmd.ExecuteReader();
                Dt.Load(Dr);
            }
            catch (Exception e)
            {
                throw new Exception("erro ao acessar os produtos" + e.Message);
            }
            finally
            {
                Desconectar();
            }
            return Dt;
        }
        public int getNumPedidosProntos()
        {
            int countPeds = 0;
            try
            {
                Conectar();

                NpgsqlCommand Cmd = new NpgsqlCommand("getnumpedidosprontos", Cn); //Procedure do login
                Cmd.CommandType = CommandType.StoredProcedure;
                countPeds = Convert.ToInt32(Cmd.ExecuteScalar());

            }
            catch (Exception e) { MessageBox.Show(e.Message, "ERRO"); }
            finally { Desconectar(); }
            return countPeds;
        }

        public DataTable getEndCli(int idPed)
        {
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("getenderecocliente", Cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("idpedido", idPed);
                Dr = Cmd.ExecuteReader();
                Dt.Load(Dr);
            }
            catch (Exception e)
            {
                throw new Exception("erro ao acessar os produtos" + e.Message);
            }
            finally
            {
                Desconectar();
            }
            return Dt;
        }

        public void setPedidoPronto(int idpedido)
        {
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("setPedidoPronto", Cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("idpedido", idpedido);
                Cmd.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
                throw new Exception("erro ao acessar os produtos" + e.Message);
            }
            finally
            {
                Desconectar();
            }
        }
        public void setPedidoaCaminho(int idpedido)
        {
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("setPedidoaCaminho", Cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("idpedido", idpedido);
                Cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception("erro ao acessar os produtos" + e.Message);
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
