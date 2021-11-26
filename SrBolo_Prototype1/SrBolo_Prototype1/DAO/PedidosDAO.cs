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

        public DataTable bolosCadastrados(int id) 
        {
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("ListarBolos", Cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("idpedido", id);
                Dr = Cmd.ExecuteReader();
                Dt.Load(Dr);
            }
            catch (Exception e)
            {
                throw new Exception("erro ao acessar os Bolos" + e.Message);
            }
            finally
            {
                Desconectar();
            }
            return Dt;
        }

        public void getPedido(int idPedido) {
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("GetPedido", Cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("idpedido", idPedido);
                Dr = Cmd.ExecuteReader();
                if (Dr.HasRows) { 
                    while (Dr.Read())
                    {
                        Pedido.idPedido = Dr.GetInt32(0);
                        if (Dr.IsDBNull(1))
                        {
                            Pedido.cpfFunc = "Pedido online";
                        }
                        else {
                            Pedido.cpfFunc = Dr.GetString(1);
                        }
                        string[] Edson3 = Dr.GetString(2).Split('-');
                        Pedido.DataCompra = new DateTime(int.Parse(Edson3[0]), int.Parse(Edson3[1]), int.Parse(Edson3[2]));
                        //Deus no comando
                    }               
                }
                Desconectar();
                Conectar();
                Cmd = new NpgsqlCommand("ListarBolos", Cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("idpedido", idPedido);
                Dr = Cmd.ExecuteReader();
                Dt.Load(Dr);
                Pedido.BolosPedido = Dt;
            }
            catch (Exception e)
            {
                throw new Exception("erro ao acessar os Bolos" + e.Message);
            }
            finally {
                Desconectar();
            }
        
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

        public void setPedidos(int IdPedido)
        {
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("ListarPeds", Cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("id_peds", IdPedido);
                Dr = Cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        PedidoE.id = Dr.GetInt32(0);
                        PedidoE.email = Dr.GetString(1);
                        PedidoE.cpf = Dr.GetString(2);
                        PedidoE.idendereco = Dr.GetInt32(3);
                        PedidoE.idcupons = Dr.GetInt32(4);
                        PedidoE.datacompra = Dr.GetString(5);
                        PedidoE.dataentrega = Dr.GetString(6);
                        PedidoE.status = Dr.GetString(7);
                        PedidoE.ecommerce = Dr.GetBoolean(8);

                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("erro ao acessar os pedidos" + e.Message);
            }
            finally
            {
                Desconectar();
            }
        }




    }
}
