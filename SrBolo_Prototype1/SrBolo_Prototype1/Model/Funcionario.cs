using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrBolo_Prototype1.Model
{
    public abstract class Funcionario
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }

        public Funcionario(string cpf, string nome, string rg, string email, string telefone, string senha)
        {
            Cpf = cpf;
            Nome = nome;
            Rg = rg;
            Email = email;
            Telefone = telefone;
            Senha = senha;
        }
    }


}

