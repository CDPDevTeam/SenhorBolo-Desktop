using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace SrBolo_Prototype1.DAO
{
    class ProdutoDAO : ClassConexao
    {
        public int ContagemVendasMes()
        {
            DateTime dataAtual = DateTime.Now;
            DateTime inicioMes = new DateTime(dataAtual.Year, dataAtual.Month, 1,0,0,0);
            Conectar();

            NpgsqlCommand Cmd = new NpgsqlCommand("ContagemVendas", Cn); //Procedure do login
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@inicioMes", inicioMes.ToString("yyyy-MM-dd"));
            Cmd.Parameters.AddWithValue("@dataAtual", dataAtual.ToString("yyyy-MM-dd"));
            
            Dr = Cmd.ExecuteReader();
            return int.Parse(Dr.GetString(0));
        }
    }
}
