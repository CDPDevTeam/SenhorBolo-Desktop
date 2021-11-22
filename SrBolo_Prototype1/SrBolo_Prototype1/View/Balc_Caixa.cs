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

            txtTotalRecebido.Enabled = false;
            
            
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
            if (e.KeyCode == Keys.F)
            {
                finalizarCompra();
                txtTotalRecebido.Enabled = true;
                txtTotalRecebido.Focus();
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
                txtCaixaSubtotal.Text = totalitem.ToString();
                adicionarProduto();
                txtCodigoBarras.Focus();
            }
            if (e.KeyCode == Keys.F)
            {
                finalizarCompra();
                txtTotalRecebido.Enabled = true;
                txtTotalRecebido.Focus();
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

        private void finalizarCompra()
        {
            if (MessageBox.Show("Deseja finalizar compra?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int idProduto;
                int qtde;
                double valorUnit;
                caixa.gerarVenda();
                for (int i = 0; i < GridViewCaixa.Rows.Count - 1; i++)
                {
                    idProduto = Convert.ToInt32(GridViewCaixa.Rows[i].Cells[0].Value);
                    qtde = Convert.ToInt32(GridViewCaixa.Rows[i].Cells[2].Value);
                    valorUnit = Convert.ToDouble(GridViewCaixa.Rows[i].Cells[3].Value);
                    caixa.gerarQtdeVenda(idProduto, valorUnit, qtde);
                }
                limparTextoProduto();
                txtCodigoBarras.Enabled = true;
                txtCaixaQtd.Enabled = true;
                GridViewCaixa.Rows.Clear();
                GridViewCaixa.Refresh();
            }
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
            txtCodigoBarras.Focus();
        }

        private void Balc_Caixa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Balc_Caixa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F)
            {
                finalizarCompra();
                txtTotalRecebido.Enabled = true;
                txtTotalRecebido.Focus();
            }
        }

        private void Balc_Caixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'F')
            {
                finalizarCompra();
                txtTotalRecebido.Enabled = true;
                txtTotalRecebido.Focus();
            }
        }
    }
}
