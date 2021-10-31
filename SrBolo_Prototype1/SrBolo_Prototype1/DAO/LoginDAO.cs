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
        public bool Acessar(Funcionario func,string cargo, string login, String senha)
        {
            Funcionario user;
            try
            {
                Conectar();
                
                NpgsqlCommand Cmd = new NpgsqlCommand("AcessoSistema", Cn); //Procedure do login
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@cargo", cargo);
                Cmd.Parameters.AddWithValue("@cpf", login);
                Cmd.Parameters.AddWithValue("@senha", senha);
                
                Dr = Cmd.ExecuteReader();
                if (Dr.HasRows) //Checa se retorna valor
                {
                    while (Dr.Read())
                    {
                        
                        if (cargo == "Gerente")
                        {
                            func = new Gerente(Dr.GetString(0), Dr.GetString(1), Dr.GetString(2), Dr.GetString(3), Dr.GetString(4), Dr.GetString(5));
                        }else if (cargo == "Balconista"){
                            func = new Balconista(Dr.GetString(0), Dr.GetString(1), Dr.GetString(2), Dr.GetString(3), Dr.GetString(4), Dr.GetString(5));
                        }
                        else{
                            func = new Confeiteiro(Dr.GetString(0), Dr.GetString(1), Dr.GetString(2), Dr.GetString(3), Dr.GetString(4), Dr.GetString(5));
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
            Funcionario func;

        }
    }
}
