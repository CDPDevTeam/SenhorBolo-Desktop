using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrBolo_Prototype1.Model
{
    class PedidoE
    {
        public int id { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public int idendereco { get; set; }
        public int idcupons { get; set; }
        public string datacompra { get; set; }
        public string dataentrega { get; set; }
        public string status { get; set; }
        public bool ecommerce { get; set; }

    }
}
