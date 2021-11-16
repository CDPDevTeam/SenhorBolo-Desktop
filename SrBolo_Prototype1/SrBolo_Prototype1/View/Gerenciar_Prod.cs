using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SrBolo_Prototype1.View;
using SrBolo_Prototype1.Control;

namespace SrBolo_Prototype1
{
    public partial class Gerenciar_Prod : Form
    {
        ControleProduto produtos = new ControleProduto();
        DataTable produtosCadastrados = new DataTable();
        public Gerenciar_Prod()
        {
            InitializeComponent();
            CustumizeDesing();
        }
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

        private void BtnReceita_Click(object sender, EventArgs e)
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

        private void btnGerenciar_PedE_Click(object sender, EventArgs e)
        {
            Gerenciar_PedE gerenciar_PedE = new Gerenciar_PedE();
            gerenciar_PedE.Show();
            this.Hide();
        }

        private void btnGerenciar_PedF_Click(object sender, EventArgs e)
        {
            Gerenciar_PedF gerenciar_PedF = new Gerenciar_PedF();
            gerenciar_PedF.Show();
            this.Hide();
        }

        private void LogoMrCake_Click(object sender, EventArgs e)
        {
            Adm_Home adm_Home = new Adm_Home();
            adm_Home.Show();
            this.Hide();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            Editar_Prod editar_Prod = new Editar_Prod();
            editar_Prod.Show();
            this.Hide();
        }

        public void listarProduto() {
            produtosCadastrados = produtos.produtosCadastrados();
            GridViewProd.DataSource = produtosCadastrados;
        }

        private void Gerenciar_Prod_Load(object sender, EventArgs e)
        {
            listarProduto();
        }

        private void ButtonExc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja apagar esse produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int idProd = int.Parse(GridViewProd.CurrentRow.Cells[0].Value.ToString());
                produtos.excluirProduto(idProd);
                GridViewProd.Rows.RemoveAt(GridViewProd.CurrentRow.Index);
                MessageBox.Show("Produto apagado com sucesso", "Sucesso", MessageBoxButtons.OK);
            }
        }
    }
}
