using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrBolo_Prototype1.DAO
{
    class CoberturaDAO : ClassConexao
    {
        DataTable Dt = new DataTable();
        public DataTable getCobertura()
        {
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("Select cobertura_bolo from cobertura_bolo", Cn);
                Dr = Cmd.ExecuteReader();
                Dt.Load(Dr);
            }
            catch (Exception e)
            {
                throw new Exception("erro ao acessar os confeitos" + e.Message);
            }
            finally
            {
                Desconectar();
            }
            return Dt;
        }
    }
}
