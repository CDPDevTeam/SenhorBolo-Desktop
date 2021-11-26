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
using SrBolo_Prototype1.Model;
using SrBolo_Prototype1.Control;
using SrBolo_Prototype1.DAO;

namespace SrBolo_Prototype1
{
    public partial class Gerenciar_PedF : Form
    { 
        ControlePedidos pedidos = new ControlePedidos();
        PedidosDAO teste = new PedidosDAO();
        DataTable pedidosCadastrados = new DataTable();
    
        public Gerenciar_PedF()
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

        private void LogoMrCake_Click(object sender, EventArgs e)
        {
            Adm_Home adm_Home = new Adm_Home();
            adm_Home.Show();
            this.Hide();
        }

        public void listarPedidos()
        {
            pedidosCadastrados = teste.pedidosCadastrados();
            GridViewRec.DataSource = pedidosCadastrados;

        }

        private void Gerenciar_PedF_Load(object sender, EventArgs e)
        {
            lblNome.Text = Gerente.Nome;
            lblEmail.Text = Gerente.Email;
            listarPedidos();
            DataTable edson = new DataTable();
            edson = teste.pedidosCadastrados();
        }

        private void txtGerRecSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataView data = pedidosCadastrados.DefaultView;
                data.RowFilter = string.Format("CONVERT(id_pedido, 'System.String') like '%{0}%' or cpf_func_fk like '%{0}%' or CONVERT(data_compra, 'System.String') like '%{0}%' or CONVERT(data_entrega, 'System.String') like '%{0}%'", txtGerRecSearch.Text);
                GridViewRec.DataSource = data.ToTable();
            }
        }

        private void ButtonExibir_Click(object sender, EventArgs e)
        {
            int indice = GridViewRec.SelectedRows[0].Index;
            pedidos.getPedidos(int.Parse(GridViewRec.Rows[indice].Cells[0].Value.ToString()));
            Adm_Pedido adm_Pedido = new Adm_Pedido();
            adm_Pedido.Show();
        }
    }
}
