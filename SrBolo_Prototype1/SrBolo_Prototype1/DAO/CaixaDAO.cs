using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using SrBolo_Prototype1.common;
using System.Windows.Forms;
using SrBolo_Prototype1.Model;

namespace SrBolo_Prototype1.DAO
{
    class CaixaDAO : ClassConexao
    {
        public double getProduto(int cod)
        {
            double preco = 0;
            try
            {
                Conectar();

                NpgsqlCommand Cmd = new NpgsqlCommand("getproduto", Cn); //Procedure do login
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("idprod", cod);
                Dr = Cmd.ExecuteReader();
                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        Produto.Id = Dr.GetInt32(0);
                        Produto.Confeito = Dr.GetString(1);
                        Produto.Massa = Dr.GetString(2);
                        Produto.Recheio = Dr.GetString(3);
                        Produto.Cobertura = Dr.GetString(4);
                        Produto.Categoria = Dr.GetString(5);
                        Produto.Nome = Dr.GetString(6); 
                        Produto.Foto = Dr.GetString(7);
                        Produto.ValorUnit = Dr.GetDouble(8);
                    }
                }
            }
            catch(Exception e) { MessageBox.Show(e.Message, "ERRO"); }
            finally { Desconectar(); }
            return preco;
        }

        public void gerarVenda()
        {
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("criarPedido", Cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("cpf_func",Balconista.Cpf);
                Cmd.Parameters.AddWithValue("datas", DateTime.Now.ToString("yyyy-MM-dd"));
                Cmd.ExecuteNonQuery();
            }
            finally
            {
                Desconectar();
            }
        }

        public void gerarQtdeVenda(int idProd, double vlrUnit,int qtde)
        {
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("criarqtdePedido", Cn);
                
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("id_prod", idProd);
                Cmd.Parameters.AddWithValue("vlrUnit", vlrUnit);
                Cmd.Parameters.AddWithValue("qtdePed", qtde);
                Cmd.ExecuteNonQuery();
            }
            finally
            {
                Desconectar();
            }
        }
    }

}
