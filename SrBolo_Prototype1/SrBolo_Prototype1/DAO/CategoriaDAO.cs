using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrBolo_Prototype1.DAO
{
    class CategoriaDAO : ClassConexao
    {
        DataTable Dt = new DataTable();
        public DataTable getCategoria()
        {
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("Select nome_catprod from categoria_produto", Cn);
                Dr = Cmd.ExecuteReader();
                Dt.Load(Dr);
            }
            catch (Exception e)
            {
                throw new Exception("erro ao acessar as categorias " + e.Message);
            }
            finally
            {
                Desconectar();
            }
            return Dt;
        }
    }
}
