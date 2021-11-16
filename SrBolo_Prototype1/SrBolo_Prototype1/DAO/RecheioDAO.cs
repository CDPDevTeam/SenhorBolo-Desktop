using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrBolo_Prototype1.DAO
{
    class RecheioDAO : ClassConexao
    {
        DataTable Dt = new DataTable();
        public DataTable getRecheio()
        {
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("Select recheio_bolo from recheio_bolo", Cn);
                Dr = Cmd.ExecuteReader();
                Dt.Load(Dr);
            }
            catch (Exception e)
            {
                throw new Exception("erro ao acessar os recheios" + e.Message);
            }
            finally
            {
                Desconectar();
            }
            return Dt;
        }
    }
}
