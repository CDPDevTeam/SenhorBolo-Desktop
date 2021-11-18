using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Data;


namespace SrBolo_Prototype1.DAO
{
    class ProdutoDAO : ClassConexao
    {
        public double VendasMes()
         {
            double total = 0;
             try
             {
                 DateTime dataAtual = DateTime.Now;
                 DateTime inicioMes = new DateTime(dataAtual.Year, dataAtual.Month, 1, 0, 0, 0);
                 Conectar();

                 NpgsqlCommand Cmd = new NpgsqlCommand("VendasMes", Cn); //Procedure do login
                 Cmd.CommandType = CommandType.StoredProcedure;
                 Cmd.Parameters.AddWithValue("dataatual", dataAtual.ToString("yyyy-MM-dd"));
                 Cmd.Parameters.AddWithValue("iniciomes", inicioMes.ToString("yyyy-MM-dd"));
                
                 total = Double.Parse(Cmd.ExecuteScalar().ToString());
            }
             catch (Exception e) {
                MessageBox.Show(e.Message, "ERRO");
            }
             finally { Desconectar(); }
            return total;
        }


        public double TicketMedio()
        {
            double media = 0;
            try
            {
                DateTime dataAtual = DateTime.Now;
                DateTime inicioMes = new DateTime(dataAtual.Year, dataAtual.Month, 1, 0, 0, 0);
                Conectar();

                NpgsqlCommand Cmd = new NpgsqlCommand("TicketMedio", Cn); //Procedure do login
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("dataatual", dataAtual.ToString("yyyy-MM-dd"));
                Cmd.Parameters.AddWithValue("iniciomes", inicioMes.ToString("yyyy-MM-dd"));

                media = Double.Parse(Cmd.ExecuteScalar().ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERRO");
            }
            finally { Desconectar(); }
            return media;
        }


        DataTable dt = new DataTable();
         public DataTable MaisVendidos()
         {
             try
             {
                Conectar();
                NpgsqlCommand cmd = new NpgsqlCommand("maisvendidos", Cn);
                cmd.CommandType = CommandType.StoredProcedure;
                Dr = cmd.ExecuteReader();
                dt.Load(Dr);
                
             }
             catch (Exception e){
                MessageBox.Show(e.Message, "ERRO");

            }
             finally { Desconectar(); }
            return dt;
         }

        DataTable Dt = new DataTable();
        public DataTable produtosCadastrados() {
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("ListarProd", Cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Dr = Cmd.ExecuteReader();
                Dt.Load(Dr);
            }
            catch (Exception e)
            {
                throw new Exception("erro ao acessar os produtos" + e.Message);
            }
            finally {
                Desconectar();
            }
            return Dt;
        }

        public bool CadastroProd(int idProd, string confeito, string massa, string recheio, string cobertura, string categoria, string nome, string foto)
        {
            bool cadastro = false;
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("CadProd", Cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("idProd", idProd);
                Cmd.Parameters.AddWithValue("confeito", confeito);
                Cmd.Parameters.AddWithValue("massa", massa);
                Cmd.Parameters.AddWithValue("recheio", recheio);
                Cmd.Parameters.AddWithValue("cobertura", cobertura);
                Cmd.Parameters.AddWithValue("categoria", categoria);
                Cmd.Parameters.AddWithValue("nome", nome);
                Cmd.Parameters.AddWithValue("foto", foto);
                Cmd.ExecuteNonQuery();
                cadastro = true;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao cadastrar: " + e.Message);
            }
            finally
            {
                Desconectar();
            }
            return cadastro;
        }

        public void excluirProduto(int idProd)
        {
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("ExcProd", Cn);
                Cmd.Parameters.AddWithValue("prod", idProd);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "erro");
                throw new Exception("Erro ao excluir o produto: " + e.Message);
            }
            finally
            {
                Desconectar();
            }
        }



    }
}
