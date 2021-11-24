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
        ProdutoDAO produtoDAO = new ProdutoDAO();

        public DataTable produtosCadastrados()
        {
            produtos = produtoDAO.produtosCadastrados();
            return produtos;
        }
        public bool CadastroProd(int idProd, string confeito, string massa, string recheio, string cobertura, string categoria, string nome, string foto)
        {
            return produtoDAO.CadastroProd(idProd, confeito, massa, recheio, cobertura, categoria, nome, foto);
        }

        public DataTable getProdutos()
        {
            produtos = produtoDAO.produtosCadastrados();
            return produtos;
        }

        public void setProduto(int id)
        {
            produtoDAO.setProduto(id);
        }

        public void excluirProduto(int idProd)
        {
            produtoDAO.excluirProduto(idProd);
        }
    }
}
