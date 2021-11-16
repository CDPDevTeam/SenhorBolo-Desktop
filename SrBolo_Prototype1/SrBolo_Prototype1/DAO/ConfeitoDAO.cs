using System;
using System.Data;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrBolo_Prototype1.DAO
{
    class ConfeitoDAO : ClassConexao
    {
        DataTable Dt = new DataTable();
        public DataTable getConfeitos()
        {
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("Select confeito_bolo from confeito_bolo", Cn);
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
