using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SrBolo_Prototype1.DAO;

namespace SrBolo_Prototype1.Control
{
    class ControleCaixa
    {
        CaixaDAO caixa = new CaixaDAO();

        public void getProduto(int cod)
        {
            caixa.getProduto(cod);
        }
    }
}
