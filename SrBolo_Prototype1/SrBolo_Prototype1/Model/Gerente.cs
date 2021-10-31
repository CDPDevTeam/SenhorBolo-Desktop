using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrBolo_Prototype1.Model
{
    class Gerente : Funcionario
    {
        public Gerente(string cpf, string nome, string rg, string email, string telefone, string senha)
            : base(cpf, nome, rg, email, telefone, senha)
        {

        }

    }
}
