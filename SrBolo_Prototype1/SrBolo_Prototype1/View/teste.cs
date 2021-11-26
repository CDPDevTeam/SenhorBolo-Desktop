using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SrBolo_Prototype1.Model;
using SrBolo_Prototype1.Control;

namespace SrBolo_Prototype1.View
{
    public partial class teste : Form
    {
        public teste()
        {
            InitializeComponent();
        }
        ControleConfeiteiro conf = new ControleConfeiteiro();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void teste_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conf.getPedidosaCaminho();
        }
    }
}
