using System;
using System.Data;
using Npgsql;
using SrBolo_Prototype1.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SrBolo_Prototype1.common;

namespace SrBolo_Prototype1.DAO
{
    class FuncionarioDAO : ClassConexao
    {
        DataTable Dt = new DataTable();

        public DataTable funcionariosCadastrados()
        {
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("ListarFunc", Cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Dr = Cmd.ExecuteReader();
                Dt.Load(Dr);
            }

            catch (Exception e)
            {
                throw new Exception("erro ao acessar os funcionários" + e.Message);
            }
            finally {
                Desconectar();
            
            }
            return Dt;
        }

        public bool CadastroFunc(string cpf, string cargo, string senha, string email, string tel, string nome) 
        {
            bool cadastro = false;
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("CadFunc", Cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("cpf", cpf);
                Cmd.Parameters.AddWithValue("cargo", cargo);
                Cmd.Parameters.AddWithValue("senha", senha);
                Cmd.Parameters.AddWithValue("email", email);
                Cmd.Parameters.AddWithValue("telefone", tel);
                Cmd.Parameters.AddWithValue("nome", nome);
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

        public bool updateFuncionario()
        {
            bool update = false;
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("UpdFunc", Cn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("cpf", Funcionario.Cpf);
                Cmd.Parameters.AddWithValue("cargo", Funcionario.Cargo);
                Cmd.Parameters.AddWithValue("senha", Funcionario.Senha);
                Cmd.Parameters.AddWithValue("email", Funcionario.Email);
                Cmd.Parameters.AddWithValue("telefone", Funcionario.Telefone);
                Cmd.Parameters.AddWithValue("nome", Funcionario.Nome);
                Cmd.ExecuteNonQuery();
                update = true;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao dar update: " + e.Message);
            }
            finally 
            {
                Desconectar(); 
            }
            return update;
        }

        public void excluirFuncionario(string cpf)
        {
            try
            {
                Conectar();
                NpgsqlCommand Cmd = new NpgsqlCommand("ExcFunc", Cn);
                Cmd.Parameters.AddWithValue("@cpf", cpf);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir o funcionário: " + e.Message);
            }
            finally 
            {
                Desconectar();
            }
        }
    }
}
