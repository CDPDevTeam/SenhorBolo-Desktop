using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SrBolo_Prototype1.DAO;

namespace SrBolo_Prototype1.Control
{
    class ControleConfeito
    {
        DataTable confeitos = new DataTable();
        ConfeitoDAO confeitoDAO = new ConfeitoDAO();
        public DataTable getConfeitos()
        {
            confeitos = confeitoDAO.getConfeitos();
            return confeitos;
        }
    }
}
