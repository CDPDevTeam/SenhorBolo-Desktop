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
using System.Globalization;

namespace SrBolo_Prototype1
{
    public partial class Balc_Caixa : Form
    {
        public Balc_Caixa()
        {
            InitializeComponent();
            
            

            
        }
        ControleCaixa caixa = new ControleCaixa();
        double subtotal = 0;

        private void txtCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {

           
            if (e.KeyCode == Keys.Enter)
            {
                caixa.getProduto(int.Parse(txtCodigoBarras.Text));
                txtCaixaVlrUnit.Text = Produto.ValorUnit.ToString();
                txtCaixaQtd.Focus();
            }
            if(e.KeyCode == Keys.E)
            {
                caixa.getProduto(int.Parse(txtCodigoBarras.Text));
                Consult_Prod consult_Prod = new Consult_Prod();
                consult_Prod.Show();
            }
            
            
        }
        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCaixaQtd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double totalitem = double.Parse(txtCaixaQtd.Text) * double.Parse(txtCaixaVlrUnit.Text);
                subtotal += totalitem;
                adicionarProduto();
                txtCodigoBarras.Focus();
            }
            if (e.KeyCode == Keys.E)
            {
                caixa.getProduto(int.Parse(txtCodigoBarras.Text));
                Consult_Prod consult_Prod = new Consult_Prod();
                consult_Prod.Show();
            }
        }

        public void adicionarProduto()
        {
            int linha = 0;
            GridViewCaixa.Rows.Add();
            linha = GridViewCaixa.Rows.Count - 2;
            GridViewCaixa[0, linha].Value = Produto.Id;
            GridViewCaixa[1, linha].Value = Produto.Nome;
            GridViewCaixa[2, linha].Value = txtCaixaQtd.Text;
            GridViewCaixa[3, linha].Value = Produto.ValorUnit;
            GridViewCaixa[4, linha].Value = subtotal;
            limparTextoProduto();
        }

        public void limparTextoProduto()
        {
            txtCodigoBarras.Text = null;
            txtCaixaVlrUnit.Text = null;
            txtCaixaQtd.Text = null;
            txtCaixaTotal.Text = null;
            txtCaixaSubtotal.Text = null;
            txtTroco.Text = null;
            txtTotalRecebido.Text = null;
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
