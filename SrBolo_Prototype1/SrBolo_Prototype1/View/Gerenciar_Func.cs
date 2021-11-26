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
using SrBolo_Prototype1.Model;

namespace SrBolo_Prototype1
{
    public partial class Gerenciar_Func : Form
    {
        ControleFuncionario funcionarios = new ControleFuncionario();
        DataTable funcionariosCadastrados = new DataTable();


        public Gerenciar_Func()
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
            Editar_Func editar_func = new Editar_Func();
            editar_func.Show();
            this.Hide();
        }

        public void listarFuncionarios() {
            funcionariosCadastrados = funcionarios.funcionariosCadastrados();
            GridViewFunc.DataSource = funcionariosCadastrados;

        }



        private void Gerenciar_Func_Load(object sender, EventArgs e)
        {
            lblNome.Text = Gerente.Nome;
            lblEmail.Text = Gerente.Email;
            listarFuncionarios();
        }

        private void ButtonExc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja apagar esse funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string cpf = GridViewFunc.CurrentRow.Cells[0].Value.ToString();
                funcionarios.excluirFuncionario(cpf);
                GridViewFunc.Rows.RemoveAt(GridViewFunc.CurrentRow.Index);
                MessageBox.Show("Funcionário apagado com sucesso", "Sucesso", MessageBoxButtons.OK);
            }
        }

        private void ButtonAdc_Click(object sender, EventArgs e)
        {
            Cad_Func cad_Func = new Cad_Func();
            cad_Func.Show();
            this.Hide();
        }

        private void txtGerFuncSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGerFuncSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataView data = funcionariosCadastrados.DefaultView;
                data.RowFilter = string.Format("cpf_func like '%{0}%' or nome_func like '%{0}%'", txtGerFuncSearch.Text);
                GridViewFunc.DataSource = data.ToTable();
            }
        }
    }
}
