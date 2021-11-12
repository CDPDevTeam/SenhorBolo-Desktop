using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace SrBolo_Prototype1.DAO
{
    class UsuarioDAO : ClassConexao
    {
        public int UsuariosCadastrados()
        {
            int qtdeUsuarios = 0;

            Conectar();

            NpgsqlCommand Cmd = new NpgsqlCommand("qtdeUsuarios", Cn); //Procedure do login
            Cmd.CommandType = CommandType.StoredProcedure;

            qtdeUsuarios = (int)Cmd.ExecuteScalar();

            return qtdeUsuarios;
        }
    }
}
