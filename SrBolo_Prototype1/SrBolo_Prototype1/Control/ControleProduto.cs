using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SrBolo_Prototype1.DAO;
using System.Data;

namespace SrBolo_Prototype1.Control
{
    class ControleProduto
    {
        DataTable produtos = new DataTable();
        ProdutoDAO ProdutoDAO = new ProdutoDAO();

        public DataTable produtosCadastrados()
        {
            produtos = ProdutoDAO.produtosCadastrados();
            return produtos;
        }
    }
}
