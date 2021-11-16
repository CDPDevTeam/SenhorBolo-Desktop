using SrBolo_Prototype1.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrBolo_Prototype1.Control
{
    class ControleMassa
    {
        DataTable massas = new DataTable();
        MassaDAO massaDAO = new MassaDAO();
        public DataTable getMassa()
        {
            massas = massaDAO.getMassa();
            return massas;
        }
    }
}
