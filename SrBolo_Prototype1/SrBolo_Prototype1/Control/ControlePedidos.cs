using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SrBolo_Prototype1.DAO;
using System.Data;

namespace SrBolo_Prototype1.Control
{
    class ControlePedidos
    {
        DataTable pedidose = new DataTable();
        PedidosDAO pedidoEDAO = new PedidosDAO();


        public DataTable pedidosECadastrados()
        {
            pedidose = pedidoEDAO.pedidosECadastrados();
            return pedidose;
        }


        public DataTable pedidosCadastrados()
        {
            pedidose = pedidoEDAO.pedidosCadastrados();
            return pedidose;
        }

        /*public DataTable getPedido()
        {
            pedidose = pedidoEDAO.pedidosCadastrados();
            return pedidose;
        }

        public DataTable getPedidoE() {
            pedidose = pedidoEDAO.pedidosECadastrados();
            return pedidose;
        }*/

        public void getExibirPedidos(int idpedido) {
            pedidoEDAO.getExibirPedido(idpedido);
        }
    }
}
