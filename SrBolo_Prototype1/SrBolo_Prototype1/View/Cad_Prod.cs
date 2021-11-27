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
    public partial class Cad_Prod : Form
    {
        ControleProduto produto = new ControleProduto();
        ControleConfeito confeito = new ControleConfeito();
        ControleCobertura cobertura = new ControleCobertura();
        ControleMassa massa = new ControleMassa();
        ControleRecheio recheio = new ControleRecheio();
        ControleCategoria categoria = new ControleCategoria();
        public Cad_Prod()
        {
            InitializeComponent();
            CustumizeDesing();
            comboIDConfeito();
            comboIDCobertura();
            comboIDMassa();
            comboIDRecheio();
            comboIDCategoria();
        }

        public void comboIDCategoria()
        {
            DataTable Dt = new DataTable();
            Dt = categoria.getCategoria();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                ComboBoxCadProdCategoria.Items.Add(Dt.Rows[i]["nome_catprod"].ToString());
            }
        }

        public void comboIDConfeito()
        {
            DataTable Dt = new DataTable();
            Dt = confeito.getConfeitos();
            for (int i = 0; i < Dt.Rows.Count; i++) {
                ComboBoxCadProdConfeito.Items.Add(Dt.Rows[i]["confeito_bolo"].ToString());
            }
        }
        public void comboIDCobertura()
        {
            DataTable Dt = new DataTable();
            Dt = cobertura.getCobertura();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                ComboBoxCadProdCobertura.Items.Add(Dt.Rows[i]["cobertura_bolo"].ToString());
            }
        }

        public void comboIDRecheio()
        {
            DataTable Dt = new DataTable();
            Dt = recheio.getRecheio();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                ComboBoxCadProdRecheio.Items.Add(Dt.Rows[i]["recheio_bolo"].ToString());
            }
        }

        public void comboIDMassa()
        {
            DataTable Dt = new DataTable();
            Dt = massa.getMassa();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                ComboBoxCadProdMassa.Items.Add(Dt.Rows[i]["massa_bolo"].ToString());
            }
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
            ComboBoxCadProdCobertura.Text = null;
            txtCadProdID.Text = null;
            ComboBoxCadProdConfeito.Text = null;
            ComboBoxCadProdMassa.Text = null;
            txtCadProdNome.Text = null;
            ComboBoxCadProdRecheio.Text = null;
        }

        private void ButtonCad_Click(object sender, EventArgs e)
        {
            if (ComboBoxCadProdCobertura.Text == "" || ComboBoxCadProdRecheio.Text == "" || txtCadProdID.Text == "" || ComboBoxCadProdMassa.Text == "" || txtCadProdNome.Text == "" || ComboBoxCadProdConfeito.Text == "" || ComboBoxCadProdCategoria.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios");
            }
            else
            {
                if (produto.CadastroProd(int.Parse(txtCadProdID.Text), ComboBoxCadProdConfeito.Text, ComboBoxCadProdMassa.Text, ComboBoxCadProdRecheio.Text, ComboBoxCadProdConfeito.Text, ComboBoxCadProdCategoria.Text, txtCadProdNome.Text, PictureBoxCadProd.ImageLocation.ToString()))
                {
                    MessageBox.Show("Funcionário cadastrado!", "Sucesso");
                }
                else
                {
                    MessageBox.Show("Erro no cadastro");
                }

            }
        }

        private void Cad_Prod_Load(object sender, EventArgs e)
        {
            lblNome.Text = Gerente.Nome;
            lblEmail.Text = Gerente.Email;
            timer1.Start();
            setDataHora();
        }

        private void PictureBoxCadProd_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                PictureBoxCadProd.Image = new Bitmap(open.FileName);
                // image file path  
                PictureBoxCadProd.Text = open.FileName;
            }
        }

        private void PictureBoxCadProd_MouseHover(object sender, EventArgs e)
        {

        }

        private void BtnDesc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair do sistema?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void setDataHora()
        {
            DateTime agora = DateTime.Now;
            lblData.Text = agora.Date.ToString("dddd',' dd'/'MM'/'yyyy");
            lblHora.Text = agora.TimeOfDay.ToString("hh':'mm':'ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            setDataHora();
        }
    }

}
