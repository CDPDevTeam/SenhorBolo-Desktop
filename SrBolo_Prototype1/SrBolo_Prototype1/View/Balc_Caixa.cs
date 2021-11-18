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

        private void txtCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            setDataHora();
        }
        private void setDataHora()
        {
            DateTime agora = DateTime.Now;
            lblData.Text = agora.Date.ToString("dddd',' dd'/'MM'/'yyyy");
            lblHora.Text = agora.TimeOfDay.ToString("hh':'mm':'ss");
        }

        private void Balc_Caixa_Load(object sender, EventArgs e)
        {
            lblCaixaNomeFunc.Text = Balconista.Nome;

            timer.Start();
            setDataHora();
        }

        private void Balc_Caixa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
