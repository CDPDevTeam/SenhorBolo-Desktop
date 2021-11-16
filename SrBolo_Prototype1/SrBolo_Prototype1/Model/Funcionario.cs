using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrBolo_Prototype1.Model
{
    public abstract class Funcionario
    {
        public static string Cpf { get; set; }
        public static string Nome { get; set; }
        public static string Email { get; set; }
        public static string Telefone { get; set; }
        public static string Senha { get; set; }
        public static   string Cargo { get; set; }
        public Funcionario()
        {

        }

        public Funcionario(string cpf, string nome, string email, string telefone, string senha, string cargo)
        {
            Cpf = cpf;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Senha = senha;
            Cargo = cargo;
        }
    }


}

