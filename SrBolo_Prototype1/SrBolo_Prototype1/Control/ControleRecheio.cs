using SrBolo_Prototype1.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrBolo_Prototype1.Control
{
    class ControleRecheio
    {
        DataTable recheios = new DataTable();
        RecheioDAO recheioDAO = new RecheioDAO();
        public DataTable getRecheio()
        {
            recheios = recheioDAO.getRecheio();
            return recheios;
        }
    }
}
