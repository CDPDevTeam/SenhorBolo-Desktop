﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data;

namespace SrBolo_Prototype1.DAO
{
    class UsuarioDAO : ClassConexao
    {
        public int UsuariosCadastrados()
        {
            int qtdeUsuarios = 0;
            try
            {
                

                Conectar();

                NpgsqlCommand Cmd = new NpgsqlCommand("call qtdeUsuarios", Cn); //Procedure do login
                Cmd.CommandType = CommandType.StoredProcedure;

                qtdeUsuarios = (int)Cmd.ExecuteScalar();

                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "ERRO");
            }
            finally { Desconectar(); }
            return qtdeUsuarios;
        }
    }
}
