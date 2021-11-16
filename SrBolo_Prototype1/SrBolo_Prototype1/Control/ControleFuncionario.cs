using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SrBolo_Prototype1.DAO;

namespace SrBolo_Prototype1.Control
{
    class ControleFuncionario
    {
        DataTable funcionarios = new DataTable();
        FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

        public DataTable funcionariosCadastrados() {
            funcionarios = funcionarioDAO.funcionariosCadastrados();
            return funcionarios;
        }
        public bool CadastroFunc(string cpf, string cargo, string senha, string email, string tel, string nome)
        {
            return funcionarioDAO.CadastroFunc(cpf, cargo, senha, email, tel, nome);
        }

        public void excluirFuncionario(string cpf)
        {
            funcionarioDAO.excluirFuncionario(cpf);
        }
    }
}
