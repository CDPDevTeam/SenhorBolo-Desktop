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

namespace SrBolo_Prototype1
{
    public partial class Editar_Func : Form
    {
        ControleFuncionario funcionarios = new ControleFuncionario();
        public Editar_Func()
        {
            InitializeComponent();
            CustumizeDesing();
            comboID();
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
            Limpar();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            bool update;
            Funcionario.Cpf = ComboBoxEditFuncCPF.Text;
            Funcionario.Cargo = ComboBoxEditFuncCargo.Text;
            Funcionario.Senha = txtEditFuncSenha.Text;
            Funcionario.Email = txtEditFuncEmail.Text;
            Funcionario.Nome = txtEditFuncNome.Text;
            Funcionario.Telefone = txtEditFuncTel.Text;
            update = funcionarios.updateFuncionario();
            if (update == true) 
            {
                MessageBox.Show("Funcionario alterado com sucesso!");
            }

        }

        private void Editar_Func_Load(object sender, EventArgs e)
        {
            lblNome.Text = Gerente.Nome;
            lblEmail.Text = Gerente.Email;
            ComboBoxEditFuncCargo.Items.Add("gerente");
            ComboBoxEditFuncCargo.Items.Add("caixa");
            ComboBoxEditFuncCargo.Items.Add("confeiteiro");
        }

        public void Limpar() {
            ComboBoxEditFuncCPF.Text = null;
            txtEditFuncEmail.Text = null;
            txtEditFuncNome.Text = null;
            txtEditFuncSenha.Text = null;
            txtEditFuncTel.Text = null;
            ComboBoxEditFuncCargo.Text = null;
        }

        private void ComboBoxEditFuncCPF_SelectedIndexChanged(object sender, EventArgs e)
        {
            funcionarios.setFuncionario(ComboBoxEditFuncCPF.GetItemText(ComboBoxEditFuncCPF.SelectedItem));
            txtEditFuncSenha.Text = Funcionario.Senha;
            txtEditFuncEmail.Text = Funcionario.Email;
            txtEditFuncNome.Text = Funcionario.Nome;
            txtEditFuncTel.Text = Funcionario.Telefone;
            ComboBoxEditFuncCargo.Text = Funcionario.Cargo;
        }

        public void comboID()
        {
            DataTable Dt = new DataTable();
            Dt = funcionarios.getFuncionario();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                ComboBoxEditFuncCPF.Items.Add(Dt.Rows[i]["cpf_func"].ToString());
            }
        }

        /*private void txtEditFuncTel_TextChanged(object sender, EventArgs e)
        {
            if (txtEditFuncTel.Text == null) { 
                if (txtEditFuncTel.Text.Length == 2)
                {
                    txtEditFuncTel.Text += " ";
                }
                else if (txtEditFuncTel.Text.Length == 8)
                {
                    txtEditFuncTel.Text += "-";
                }
                txtEditFuncTel.SelectionStart = txtEditFuncTel.Text.Length;
                txtEditFuncTel.SelectionLength = 0;
            }
        }*/
    }
}
