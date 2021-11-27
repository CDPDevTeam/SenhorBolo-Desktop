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
using SrBolo_Prototype1.View;
using System.Globalization;

namespace SrBolo_Prototype1.View
{
    public partial class Adm_Home : Form
    {
        public Adm_Home()
        {
            InitializeComponent();
            CustumizeDesing();
        }

        ProdutoDAO produto = new ProdutoDAO();
        UsuarioDAO usuario = new UsuarioDAO();

        
        

        private void CustumizeDesing()
        {
            PanelProduto.Visible = false;
            PanelFuncionario.Visible = false;
            PanelPedidos.Visible = false;
        }

        private void HideMenu()
        {
            if (PanelFuncionario.Visible == true)
            {
                PanelFuncionario.Visible = false;
            }
            if (PanelProduto.Visible == true)
            {
                PanelProduto.Visible = false;
            }
            if (PanelPedidos.Visible == true)
            {
                PanelPedidos.Visible = false;
            }
            
        }

        private void ShowSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        
        private void BtnFuncionario_Click(object sender, EventArgs e)
        {
            ShowSubmenu(PanelFuncionario);
        }
        private void BtnProduto_Click(object sender, EventArgs e)
        {
            ShowSubmenu(PanelProduto);
        }
        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            ShowSubmenu(PanelPedidos);
        }
        

        private void btnGerenciar_Func_Click(object sender, EventArgs e)
        {
            Gerenciar_Func gerenciar_Func = new Gerenciar_Func();
            gerenciar_Func.Show();
            this.Hide();
        }

        private void btnCad_Func_Click(object sender, EventArgs e)
        {
            Cad_Func cad_Func = new Cad_Func();
            cad_Func.Show();
            this.Hide();

        }

        private void btnCad_Prod_Click(object sender, EventArgs e)
        {
            Cad_Prod cad_Prod = new Cad_Prod();
            cad_Prod.Show();
            this.Hide();
        }

        private void btnGerenciar_Prod_Click(object sender, EventArgs e)
        {
            Gerenciar_Prod gerenciar_Prod = new Gerenciar_Prod();
            gerenciar_Prod.Show();
            this.Hide();
        }

        private void btnGerenciar_PedE_Click(object sender, EventArgs e)
        {
            Gerenciar_PedE gerenciar_PedE = new Gerenciar_PedE();
            gerenciar_PedE.Show();
            this.Hide();
            
        }
        
        private void btnGerenciarPedF_Click(object sender, EventArgs e)
        {
            Gerenciar_PedF gerenciar_PedF = new Gerenciar_PedF();
            gerenciar_PedF.Show();
            this.Hide();
        }

        private void Adm_Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void LogoMrCake_Click(object sender, EventArgs e)
        {
            
        }

        private void Adm_Home_Load(object sender, EventArgs e)
        {
            lblNome.Text = Gerente.Nome;
            lblEmail.Text = Gerente.Email;
            lblVendasMes.Text = "R$"+produto.VendasMes().ToString("F2",CultureInfo.CurrentCulture);
            lblUsuarios.Text = usuario.UsuariosCadastrados().ToString();
            dgrMaisVendidos.DataSource = produto.MaisVendidos();
            dgrChangeSize();
            lblTicketMedio.Text = "R$"+produto.TicketMedio().ToString("F2", CultureInfo.CurrentCulture);


            timer.Start();
            setDataHora();
        }

        private void setDataHora()
        {
            DateTime agora = DateTime.Now;
            lblData.Text = agora.Date.ToString("dddd',' dd'/'MM'/'yyyy");
            lblHora.Text = agora.TimeOfDay.ToString("hh':'mm':'ss");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            setDataHora();
        }

        private void dgrMaisVendidos_SizeChanged(object sender, EventArgs e)
        {
            dgrChangeSize();
        }
        private void dgrChangeSize()
        {
            dgrMaisVendidos.Columns[0].FillWeight = 80;
            dgrMaisVendidos.Columns[1].FillWeight = 20;
            dgrMaisVendidos.Refresh();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            dgrChangeSize();
        }

        private void BtnDesc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair do sistema?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
