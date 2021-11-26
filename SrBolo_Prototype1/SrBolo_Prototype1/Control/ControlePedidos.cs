﻿using System;
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

        DataTable pedidos = new DataTable();
        PedidosDAO pedidoDAO = new PedidosDAO();

        public DataTable pedidosCadastrados()
        {
            pedidos = pedidoDAO.pedidosCadastrados();
            return pedidos;
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

        public DataTable getPedidosE() {
            pedidose = pedidoEDAO.pedidosECadastrados();
            return pedidose;
        }

        public void getPedidos(int idpedido) {
            pedidoDAO.getPedido(idpedido);
        }
    }
}
