using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrBolo_Prototype1.DAO
{
    class MassaDAO : ClassConexao
    {
        DataTable Dt = new DataTable();
        public DataTable getMassa()
        {
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("Select massa_bolo from massa_bolo", Cn);
                Dr = Cmd.ExecuteReader();
                Dt.Load(Dr);
            }
            catch (Exception e)
            {
                throw new Exception("erro ao acessar as massas" + e.Message);
            }
            finally
            {
                Desconectar();
            }
            return Dt;
        }
    }
}
