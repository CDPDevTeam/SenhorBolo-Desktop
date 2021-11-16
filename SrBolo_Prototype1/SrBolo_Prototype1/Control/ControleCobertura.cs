using SrBolo_Prototype1.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrBolo_Prototype1.Control
{
    class ControleCobertura
    {
        DataTable cobertura = new DataTable();
        CoberturaDAO coberturaDAO = new CoberturaDAO();
        public DataTable getCobertura()
        {
            cobertura = coberturaDAO.getCobertura();
            return cobertura;
        }
    }
}
