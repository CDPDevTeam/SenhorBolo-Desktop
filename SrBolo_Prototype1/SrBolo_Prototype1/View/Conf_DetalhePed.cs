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
    public partial class Conf_DetalhePed : Form
    {
        public Conf_DetalhePed()
        {
            InitializeComponent();
            
            
        }

        ControleConfeiteiro conf = new ControleConfeiteiro();
        DataTable Dt = new DataTable();
        


        private void Conf_DetalhePed_Load(object sender, EventArgs e)
        {
            
            lblIdPed.Text = Pedido.idPedido.ToString();
            lblDataCompra.Text = Pedido.DataCompra.ToString("dd'-'MM'-'yyyy");
            gridViewBolosPed.DataSource = Pedido.BolosPedido;

            Dt = conf.getEndCli(Pedido.idPedido);
            lblEmailCli.Text = Dt.Rows[0][1].ToString();

            lblEnder1.Text = Dt.Rows[0][2].ToString() +", "+ Dt.Rows[0][4].ToString() + ", " + Dt.Rows[0][6].ToString();
            lblEnd2.Text = Dt.Rows[0][3].ToString() + " - " + Dt.Rows[0][5].ToString();
            lblEndObs.Text = Dt.Rows[0][7].ToString();
        }
    }
}
