using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace SrBolo_Prototype1.DAO
{
    class ClassConexao
    {
        private static String Host = "motty.db.elephantsql.com";
        private static String User= "vmnrcpwz";
        private static String DBname = "vmnrcpwz";
        private static String Password = "uN9-oJ2RFBzZF9sEFeHEdQcMNb0EJA2L";
        private static String Port = "5432";
        protected NpgsqlDataReader Dr;
        protected NpgsqlConnection Cn;
        
        public void Conectar() { 
            String Sandroval = String.Format("Server ={ 0}; Port ={ 1}; User Id = { 2 }; Password ={ 3}; Database ={ 4}; ", Host, Port, User, Password, DBname);
            Cn = new NpgsqlConnection(Sandroval);
            Cn.Open();
        }

        public void Desconectar() {
            if (Cn.State == ConnectionState.Open)
            {
                Cn.Close();
            }
            else {
                Console.WriteLine("Se fodeu aí, playboy!");
            } 
        }    
    
    }

}
