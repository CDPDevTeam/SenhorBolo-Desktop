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
        
        public DataTable pedidosCadastrados()
        {
            DataTable dados = new DataTable();
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("ListarPed", Cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Dr = Cmd.ExecuteReader();
                
                dados.Load(Dr);
            }

            catch (Exception e)
            {
                throw new Exception("erro ao acessar os pedidos" + e.Message);
            }
            finally
            {
                Desconectar();

            }
            return dados;
        }

        public DataTable pedidosECadastrados()
        {
            DataTable coisas = new DataTable();
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("ListarPedE", Cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Dr = Cmd.ExecuteReader();
                
                coisas.Load(Dr);
            }

            catch (Exception e)
            {
                throw new Exception("erro ao acessar os pedidos" + e.Message);
            }
            finally
            {
                Desconectar();

            }
            return coisas;
        }


       public void getExibirPedido(int idPedido) {
            DataTable bolos = new DataTable();
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
                
                bolos.Load(Dr);
                Pedido.BolosPedido = bolos;
            }
            catch (Exception e)
            {
                throw new Exception("erro ao acessar os Bolos" + e.Message);
            }
            finally {
                Desconectar();
            }
        
        }
    }
}
