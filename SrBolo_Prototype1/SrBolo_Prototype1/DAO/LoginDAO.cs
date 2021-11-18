using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Threading.Tasks;
using SrBolo_Prototype1.Model;


namespace SrBolo_Prototype1.DAO
{
    class LoginDAO : ClassConexao
    {
        public bool Acesso = false; //Informa se o login é valido
        public bool Acessar(string cargo, string login, String senha)
        {
            
            object[] result = new object[2];
            try
            {
                
                Conectar();
                
                NpgsqlCommand Cmd = new NpgsqlCommand("Login", Cn); //Procedure do login
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("cpfs_func", login);
                Cmd.Parameters.AddWithValue("senhas_func", senha);
                Cmd.Parameters.AddWithValue("cargos_func", cargo);
                
                Dr = Cmd.ExecuteReader();

                
                if (Dr.HasRows) //Checa se retorna valor
                {
                    while (Dr.Read())
                    {

                        if (cargo == "gerente")
                        {
                            Gerente.Cpf = Dr.GetString(0);
                            Gerente.Nome = Dr.GetString(1);
                            Gerente.Email = Dr.GetString(2);
                            Gerente.Senha = Dr.GetString(3);
                            Gerente.Cargo = Dr.GetString(4);
                        }
                        else if (cargo == "caixa") {
                            Balconista.Cpf = Dr.GetString(0);
                            Balconista.Nome = Dr.GetString(1);
                            Balconista.Email = Dr.GetString(2);
                            Balconista.Senha = Dr.GetString(3);
                            Balconista.Cargo = Dr.GetString(4);
                        }
                        else {
                            Confeiteiro.Cpf = Dr.GetString(0);
                            Confeiteiro.Nome = Dr.GetString(1);
                            Confeiteiro.Email = Dr.GetString(2);
                            Confeiteiro.Senha = Dr.GetString(3);
                            Confeiteiro.Cargo = Dr.GetString(4);
                        }
                    }
                    Acesso = true;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao cadastrar: " + e.Message);
            }
            finally
            {
                Desconectar();
            }
            
            return Acesso;
        }

        public void instaciar()
        {
            

        }
    }
}
