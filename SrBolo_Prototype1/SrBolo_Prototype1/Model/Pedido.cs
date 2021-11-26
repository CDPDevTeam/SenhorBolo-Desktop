using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SrBolo_Prototype1.Model
{
    static class Pedido
    {
        public static DataTable BolosPedido { get; set; }

        public static string cpfFunc { get; set; }

        public static DateTime DataCompra { get; set; }

        public static int idPedido { get; set; }

    }
}
