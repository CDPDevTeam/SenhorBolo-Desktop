using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SrBolo_Prototype1.DAO;
using Npgsql;
using System.Data;
using SrBolo_Prototype1.common;
using System.Windows.Forms;
using SrBolo_Prototype1.Model;

namespace SrBolo_Prototype1.Control
{
    class ControleConfeiteiro
    {
        ConfeiteiroDAO sus = new ConfeiteiroDAO();
        DataTable Dt = new DataTable();
        public int getNumPedidos()
        { 
            int contagem = sus.getNumPedidos();
            return contagem;
        }
        public DataTable getPedidosRecebidos()
        {
            Dt = sus.getPedidosRecebidos();
            return Dt;
        }

        public DataTable getPedidosaCaminho()
        {
            Dt = sus.getPedidosaCaminho();
            return Dt;
        }

        public int getNumPedidosProntos()
        {
            int contagem = sus.getNumPedidosProntos();
            return contagem;
        }
        public DataTable getEndCli(int idPed)
        {
            Dt = sus.getEndCli(idPed);
            return Dt;
        }

        public void setPedidoPronto(int idpedido)
        {
            sus.setPedidoPronto(idpedido);
        }
        public void setPedidoaCaminho(int idpedido)
        {
            sus.setPedidoaCaminho(idpedido);
        }
    }
}
