using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data;

namespace SrBolo_Prototype1.DAO
{
    class ClassConexao
    {
        private static String Host = "ec2-34-203-114-67.compute-1.amazonaws.com";
        private static String User = "ywqpycucbiguqa";
        private static String DBname = "d20gs8fi9etl55";
        private static String Password = "c0e978116cdbbb710871d3605b9591e25d69bcd53eec83591eb359b81c99e177";
        private static String Port = "5432";
        protected NpgsqlDataReader Dr;
        protected NpgsqlConnection Cn;

        public void Conectar()
        {
            String Sandroval = String.Format("Server ={0}; Port ={1}; User Id = {2}; Password ={3}; Database ={4}; SSL Mode=Require;Trust Server Certificate=true", Host, Port, User, Password, DBname);

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
