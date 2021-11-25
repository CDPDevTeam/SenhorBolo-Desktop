using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SrBolo_Prototype1.Model;
using SrBolo_Prototype1.DAO;
using SrBolo_Prototype1.View;
using SrBolo_Prototype1.Control;
using Guna.UI2.WinForms;


namespace SrBolo_Prototype1
{
    public partial class Conf_home : Form
    {
        public Conf_home()
        {
            InitializeComponent();
            CustumizeDesing();
            
        }
        DataTable Dt = new DataTable();
        ControleConfeiteiro confeiteirou = new ControleConfeiteiro();
        private void CustumizeDesing()
        {
            PanelInsumo.Visible = false;
            PanelProduto.Visible = false;
            PanelFuncionario.Visible = false;
            PanelReceita.Visible = false;
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
            if (PanelInsumo.Visible == true)
            {
                PanelInsumo.Visible = false;
            }
            if (PanelReceita.Visible == true)
            {
                PanelReceita.Visible = false;
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

        private void BtnInsumo_Click(object sender, EventArgs e)
        {
            ShowSubmenu(PanelInsumo);
        }

        private void BtnReceita_Click(object sender, EventArgs e)
        {
            ShowSubmenu(PanelReceita);
        }

        private void Conf_home_Load(object sender, EventArgs e)
        {
            lblNome.Text = Confeiteiro.Nome;
            int contagempedidos = confeiteirou.getNumPedidos();
            int contagemprontos = confeiteirou.getNumPedidosaCaminho();
            addPedidosECommerce(contagempedidos);
            addProntosEntrega(contagemprontos);
        }

        private void addPedidosECommerce(int numPedidos)
        {
            Dt = confeiteirou.getPedidosRecebidos();
            panelSlide.Width = panelBacktemplate.Width * (numPedidos + 100);

            for (int i = 1; i <= numPedidos; i++)
            {
                Guna2GradientPanel back = new Guna2GradientPanel();
                panelPrinc.Controls.Add(back);
                back.BackColor = panelBacktemplate.BackColor;
                //back.Size = new Size(583, 241);
                back.Size = panelBacktemplate.Size;
                back.BorderRadius = panelBacktemplate.BorderRadius;
                back.FillColor = panelBacktemplate.FillColor;
                back.FillColor2 = panelBacktemplate.FillColor2;
                back.BorderStyle = panelBacktemplate.BorderStyle;
                if (i == 1)
                {
                    back.Location = new Point(0, 0);
                }
                else
                {
                    back.Location = new Point((i-1)*(panelBacktemplate.Width+20), 0);
                }
                PictureBox icon = new PictureBox();
                Label lblPedido = new Label();
                Label lblIdPedido = new Label();
                Label lblEmail = new Label();
                Label lblData = new Label();
                Guna2Button btnCalcIng = new Guna2Button();
                Guna2Button btnFeito = new Guna2Button();

                back.Controls.Add(icon);
                back.Controls.Add(lblIdPedido);
                back.Controls.Add(lblPedido);
                back.Controls.Add(lblEmail);
                back.Controls.Add(lblData);
                back.Controls.Add(btnFeito);
                back.Controls.Add(btnCalcIng);

                btnCalcIng.Size = btnCalcTemplate.Size;
                btnCalcIng.Location = btnCalcTemplate.Location;
                btnCalcIng.FillColor = btnCalcTemplate.FillColor;
                btnCalcIng.Text = btnCalcTemplate.Text;
                btnCalcIng.Font = btnCalcTemplate.Font;
                btnCalcIng.Click += new EventHandler(btnCalcIng_Click);

                btnFeito.Size = btnFeitoTemplate.Size;
                btnFeito.Location = btnFeitoTemplate.Location;
                btnFeito.FillColor = btnFeitoTemplate.FillColor;
                btnFeito.Text = btnFeitoTemplate.Text;
                btnFeito.Font = btnFeitoTemplate.Font;
                

                icon.BackColor = Color.Transparent;
                icon.Location = iconTemplate.Location;
                icon.Size = iconTemplate.Size;
                icon.Image = iconTemplate.Image;
                icon.SizeMode = iconTemplate.SizeMode;

                lblPedido.Location = lblPedTemplate.Location;
                lblPedido.Font = lblPedTemplate.Font;
                lblPedido.Text = lblPedTemplate.Text;
                lblPedido.BackColor = lblIdPedTemplate.BackColor;

                lblIdPedido.Location = lblIdPedTemplate.Location;
                lblIdPedido.Font = lblIdPedTemplate.Font;
                lblIdPedido.Text = Dt.Rows[i-1][0].ToString();
                lblIdPedido.BackColor = Color.Transparent;


                lblEmail.Location = lblEmailTemplate.Location;
                lblEmail.Font = lblEmailTemplate.Font;
                lblEmail.Text = Dt.Rows[i - 1][1].ToString();
                lblEmail.BackColor = lblEmailTemplate.BackColor;
                lblEmail.AutoSize = true;

                lblData.Location = lblDatatemplate.Location;
                lblData.Font = lblDatatemplate.Font;
                lblData.Text = Dt.Rows[i - 1][2].ToString();
                lblData.BackColor = lblDatatemplate.BackColor;
                lblData.Anchor = lblDatatemplate.Anchor;
                lblData.AutoSize = true;
            }
        }

        private void addProntosEntrega(int numPedidos)
        {
            Dt = confeiteirou.getPedidosaCaminho();
            panelSlide.Width = panelBacktemplate.Width * (numPedidos + 100);

            for (int i = 1; i <= numPedidos; i++)
            {
                Guna2GradientPanel back = new Guna2GradientPanel();
                panelPrinc2.Controls.Add(back);
                back.BackColor = panelBacktemplate.BackColor;
                //back.Size = new Size(583, 241);
                back.Size = panelBacktemplate.Size;
                back.BorderRadius = panelBacktemplate.BorderRadius;
                back.FillColor = panelBacktemplate.FillColor;
                back.FillColor2 = panelBacktemplate.FillColor2;
                back.BorderStyle = panelBacktemplate.BorderStyle;
                if (i == 1)
                {
                    back.Location = new Point(0, 0);
                }
                else
                {
                    back.Location = new Point((i - 1) * (panelBacktemplate.Width + 20), 0);
                }
                PictureBox icon = new PictureBox();
                Label lblPedido = new Label();
                Label lblIdPedido = new Label();
                Label lblEmail = new Label();
                Label lblData = new Label();
                Guna2Button btnCalcIng = new Guna2Button();
                Guna2Button btnEntregue = new Guna2Button();

                back.Controls.Add(icon);
                back.Controls.Add(lblIdPedido);
                back.Controls.Add(lblPedido);
                back.Controls.Add(lblEmail);
                back.Controls.Add(lblData);
                back.Controls.Add(btnEntregue);
                back.Controls.Add(btnCalcIng);

                btnCalcIng.Size = btnCalcTemplate.Size;
                btnCalcIng.Location = btnCalcTemplate.Location;
                btnCalcIng.FillColor = btnCalcTemplate.FillColor;
                btnCalcIng.Text = btnCalcTemplate.Text;
                btnCalcIng.Font = btnCalcTemplate.Font;

                btnEntregue.Size = btnFeitoTemplate.Size;
                btnEntregue.Location = btnFeitoTemplate.Location;
                btnEntregue.FillColor = btnFeitoTemplate.FillColor;
                btnEntregue.Text = "À caminho!";
                btnEntregue.Font = btnFeitoTemplate.Font;

                icon.BackColor = Color.Transparent;
                icon.Location = iconTemplate.Location;
                icon.Size = iconTemplate.Size;
                icon.Image = iconTemplate.Image;
                icon.SizeMode = iconTemplate.SizeMode;

                lblPedido.Location = lblPedTemplate.Location;
                lblPedido.Font = lblPedTemplate.Font;
                lblPedido.Text = lblPedTemplate.Text;
                lblPedido.BackColor = lblIdPedTemplate.BackColor;

                lblIdPedido.Location = lblIdPedTemplate.Location;
                lblIdPedido.Font = lblIdPedTemplate.Font;
                lblIdPedido.Text = Dt.Rows[i - 1][0].ToString();
                lblIdPedido.BackColor = Color.Transparent;


                lblEmail.Location = lblEmailTemplate.Location;
                lblEmail.Font = lblEmailTemplate.Font;
                lblEmail.Text = Dt.Rows[i - 1][1].ToString();
                lblEmail.BackColor = lblEmailTemplate.BackColor;
                lblEmail.AutoSize = true;

                lblData.Location = lblDatatemplate.Location;
                lblData.Font = lblDatatemplate.Font;
                lblData.Text = Dt.Rows[i - 1][2].ToString();
                lblData.BackColor = lblDatatemplate.BackColor;
                lblData.Anchor = lblDatatemplate.Anchor;
                lblData.AutoSize = true;
            }
        }

        private void btnCalcIng_Click(object sender, EventArgs e)
        {
            Conf_DetalhePed conf_DetalhePed = new Conf_DetalhePed();
            conf_DetalhePed.Show();
        }
    }
}
