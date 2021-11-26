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

       public void setPedidos(int idPed)
        {
            pedidoEDAO.setPedidos(idPed);
        }

        public DataTable getPedido()
        {
            pedidose = pedidoEDAO.pedidosCadastrados();
            return pedidose;
        }

        public DataTable getPedidoE() {
            pedidose = pedidoEDAO.pedidosECadastrados();
            return pedidose;
        }

        public void getPedidos(int idpedido) {
            pedidoEDAO.getPedido(idpedido);
        }
    }
}
