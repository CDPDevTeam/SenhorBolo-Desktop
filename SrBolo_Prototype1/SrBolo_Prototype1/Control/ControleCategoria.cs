using SrBolo_Prototype1.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrBolo_Prototype1.Control
{
    class ControleCategoria
    {
        DataTable categorias = new DataTable();
        CategoriaDAO categoriaDAO = new CategoriaDAO();
        public DataTable getCategoria()
        {
            categorias = categoriaDAO.getCategoria();
            return categorias;
        }
    }
}
