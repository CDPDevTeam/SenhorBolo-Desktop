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
        public int ContagemVendasMes()
         {
             try
             {
                 DateTime dataAtual = DateTime.Now;
                 DateTime inicioMes = new DateTime(dataAtual.Year, dataAtual.Month, 1, 0, 0, 0);
                 Conectar();

                 NpgsqlCommand Cmd = new NpgsqlCommand("ContagemVendasMes", Cn); //Procedure do login
                 Cmd.CommandType = CommandType.StoredProcedure;
                 Cmd.Parameters.AddWithValue("inicioMes", inicioMes.ToString("yyyy-MM-dd"));
                 Cmd.Parameters.AddWithValue("dataAtual", dataAtual.ToString("yyyy-MM-dd"));

                 Dr = Cmd.ExecuteReader();
                 
             }
             catch (Exception e) {
                MessageBox.Show(e.Message, "ERRO");
            }
             finally { Desconectar(); }
            return int.Parse(Dr.GetString(0));
        }

        DataTable dt = new DataTable();
         public DataTable MaisVendidos()
         {
             try
             {
                Conectar();
                NpgsqlCommand cmd = new NpgsqlCommand("ListarFunc", Cn);
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

    }
}
