﻿using System;
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

        public int getNumPedidosaCaminho()
        {
            int contagem = sus.getNumPedidosaCaminho();
            return contagem;
        }
    }
}