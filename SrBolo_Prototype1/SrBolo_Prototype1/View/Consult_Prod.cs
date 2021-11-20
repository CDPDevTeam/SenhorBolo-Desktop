using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SrBolo_Prototype1.DAO;
using SrBolo_Prototype1.Model;
using SrBolo_Prototype1.common;
using SrBolo_Prototype1.Control;
using SrBolo_Prototype1.View;

namespace SrBolo_Prototype1.View
{
    public partial class Consult_Prod : Form
    {
        public Consult_Prod()
        {
            InitializeComponent();
        }

        private void Consult_Prod_Load(object sender, EventArgs e)
        {
            txtIDprod.Text = Produto.Id.ToString();
            txtNomeProd.Text = Produto.Nome;
            txtDescProd.Text = Produto.Categoria + ", "
                + "Massa: "+Produto.Massa + ", "
                + "Recheio: "+Produto.Recheio + ", "
                + "Cobertura: " + Produto.Cobertura + ", "
                + "Confeito: " + Produto.Confeito;
        }
    }
}
