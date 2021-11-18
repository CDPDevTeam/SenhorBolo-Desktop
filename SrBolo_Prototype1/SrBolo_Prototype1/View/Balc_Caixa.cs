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
using SrBolo_Prototype1.common;

namespace SrBolo_Prototype1
{
    public partial class Balc_Caixa : Form
    {
        public Balc_Caixa()
        {
            InitializeComponent();
            CaixaDAO oi = new CaixaDAO();
            double musica = 0;
            musica = oi.getProduto(14);
        }
        
    }
}
