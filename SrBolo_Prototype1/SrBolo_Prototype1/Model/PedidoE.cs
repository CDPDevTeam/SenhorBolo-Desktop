using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrBolo_Prototype1.Model
{
    public static class PedidoE
    {
        public static int id { get; set; }
        public static string email { get; set; }
        public static string cpf { get; set; }
        public static int idendereco { get; set; }
        public static int idcupons { get; set; }
        public static string datacompra { get; set; }
        public static string dataentrega { get; set; }
        public static string status { get; set; }
        public static bool ecommerce { get; set; }

    }
}
