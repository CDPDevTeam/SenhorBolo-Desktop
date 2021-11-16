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
    public partial class Cad_Func: Form
    {
        ControleFuncionario funcionario = new ControleFuncionario();
        public Cad_Func()
        {
            InitializeComponent();
            CustumizeDesing();
            ComboBoxCadFuncCargo.Items.Add("gerente");
            ComboBoxCadFuncCargo.Items.Add("confeiteiro");
            ComboBoxCadFuncCargo.Items.Add("caixa");
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

        private void BtnGerFunc_Click(object sender, EventArgs e)
        {
            Gerenciar_Func gerenciar_Func = new Gerenciar_Func();
            gerenciar_Func.Show();
            this.Hide();
        }

        private void BtnCad_Prod_Click(object sender, EventArgs e)
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

        private void ButtonLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        public void limpar() 
        {
            txtCadFuncCPF.Text = null;
            txtCadFuncEmail.Text = null;
            txtCadFuncNome.Text = null;
            txtCadFuncSenha.Text = null;
            txtCadFuncTel.Text = null;
            ComboBoxCadFuncCargo.Text = null;
        }

        private void ButtonCad_Click(object sender, EventArgs e)
        {
            if (txtCadFuncCPF.Text == "" || txtCadFuncEmail.Text == "" || txtCadFuncNome.Text == "" || txtCadFuncSenha.Text == "" || txtCadFuncTel.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios");
            }
            else
            {
                if (funcionario.CadastroFunc(txtCadFuncCPF.Text, ComboBoxCadFuncCargo.Text, txtCadFuncSenha.Text, txtCadFuncEmail.Text, txtCadFuncTel.Text, txtCadFuncNome.Text))
                {
                    MessageBox.Show("Funcionário cadastrado!", "Sucesso");
                }
                else
                {
                    MessageBox.Show("Erro no cadastro");
                }
            }
            limpar();
        }
    }
}
