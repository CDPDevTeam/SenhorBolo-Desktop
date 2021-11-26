using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SrBolo_Prototype1.Control;
using SrBolo_Prototype1.Model;


namespace SrBolo_Prototype1.View
{
    public partial class Adm_Pedido : Form
    {
        public Adm_Pedido()
        {
            InitializeComponent();

        }

        private void Adm_Pedido_Load(object sender, EventArgs e)
        {
            lblCPFFunc.Text = Pedido.cpfFunc;
            lblDataPed.Text = Pedido.DataCompra.ToString("yyyy'-'MM'-'dd");
            lblIdPed.Text = Pedido.idPedido.ToString();
            GridViewBolosPed.DataSource = Pedido.BolosPedido;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridViewBolosPed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
