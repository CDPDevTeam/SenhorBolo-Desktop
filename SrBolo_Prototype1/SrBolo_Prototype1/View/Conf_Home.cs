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
            
        }
        DataTable Dt = new DataTable();
        DataTable Diff = new DataTable();
        ControleConfeiteiro confeiteirou = new ControleConfeiteiro();
        ConfeiteiroDAO cDAO = new ConfeiteiroDAO();
        ControlePedidos pedido = new ControlePedidos();

        private void Conf_home_Load(object sender, EventArgs e)
        {
            lblNome.Text = Confeiteiro.Nome;
            timer1.Start();
            setDataHora();
            int contagempedidos = confeiteirou.getNumPedidos();
            int contagemprontos = confeiteirou.getNumPedidosProntos();
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
                btnCalcIng.Click += (s, e) => {
                    pedido.getExibirPedidos(int.Parse(lblIdPedido.Text));
                    Conf_DetalhePed conf_DetalhePed = new Conf_DetalhePed();
                    conf_DetalhePed.Show();
                };

                btnFeito.Size = btnFeitoTemplate.Size;
                btnFeito.Location = btnFeitoTemplate.Location;
                btnFeito.FillColor = btnFeitoTemplate.FillColor;
                btnFeito.Text = btnFeitoTemplate.Text;
                btnFeito.Font = btnFeitoTemplate.Font;
                btnFeito.Click += (s, e) => {
                    confeiteirou.setPedidoPronto(int.Parse(lblIdPedido.Text));
                    this.Controls.Clear();
                    this.InitializeComponent();
                    int contagempedidos = confeiteirou.getNumPedidos();
                    int contagemprontos = confeiteirou.getNumPedidosProntos();
                    addPedidosECommerce(contagempedidos);
                    addProntosEntrega(contagemprontos);
                };


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
            Diff = cDAO.getPedidosaCaminho();

            panelSlide.Width = panelBacktemplate.Width * (numPedidos + 100);

            for (int i = 1; i <= numPedidos; i++)
            {
                Guna2GradientPanel back2 = new Guna2GradientPanel();
                panelPrinc2.Controls.Add(back2);
                back2.BackColor = panelBacktemplate.BackColor;
                //back.Size = new Size(583, 241);
                back2.Size = panelBacktemplate.Size;
                back2.BorderRadius = panelBacktemplate.BorderRadius;
                back2.FillColor = panelBacktemplate.FillColor;
                back2.FillColor2 = panelBacktemplate.FillColor2;
                back2.BorderStyle = panelBacktemplate.BorderStyle;
                if (i == 1)
                {
                    back2.Location = new Point(0, 0);
                }
                else
                {
                    back2.Location = new Point((i - 1) * (panelBacktemplate.Width + 20), 0);
                }
                PictureBox icon2 = new PictureBox();
                Label lblPedido2 = new Label();
                Label lblIdPedido2 = new Label();
                Label lblEmail2 = new Label();
                Label lblData2 = new Label();
                Guna2Button btnCalcIng2 = new Guna2Button();
                Guna2Button btnEntregue2 = new Guna2Button();

                back2.Controls.Add(icon2);
                back2.Controls.Add(lblIdPedido2);
                back2.Controls.Add(lblPedido2);
                back2.Controls.Add(lblEmail2);
                back2.Controls.Add(lblData2);
                back2.Controls.Add(btnEntregue2);
                back2.Controls.Add(btnCalcIng2);

                btnCalcIng2.Size = btnCalcTemplate.Size;
                btnCalcIng2.Location = btnCalcTemplate.Location;
                btnCalcIng2.FillColor = btnCalcTemplate.FillColor;
                btnCalcIng2.Text = btnCalcTemplate.Text;
                btnCalcIng2.Font = btnCalcTemplate.Font;
                btnCalcIng2.Click += (s, e) => {
                    pedido.getExibirPedidos(int.Parse(lblIdPedido2.Text));
                    Conf_DetalhePed conf_DetalhePed = new Conf_DetalhePed();
                    conf_DetalhePed.Show();
                };

                btnEntregue2.Size = btnFeitoTemplate.Size;
                btnEntregue2.Location = btnFeitoTemplate.Location;
                btnEntregue2.FillColor = btnFeitoTemplate.FillColor;
                btnEntregue2.Text = "À caminho!";
                btnEntregue2.Font = btnFeitoTemplate.Font;
                btnEntregue2.Click += (s, e) => {
                    
                    confeiteirou.setPedidoaCaminho(int.Parse(lblIdPedido2.Text));
                    this.Controls.Clear();
                    this.InitializeComponent();
                    int contagempedidos = confeiteirou.getNumPedidos();
                    int contagemprontos = confeiteirou.getNumPedidosProntos();
                    addPedidosECommerce(contagempedidos);
                    addProntosEntrega(contagemprontos);
                };

                icon2.BackColor = Color.Transparent;
                icon2.Location = iconTemplate.Location;
                icon2.Size = iconTemplate.Size;
                icon2.Image = iconTemplate.Image;
                icon2.SizeMode = iconTemplate.SizeMode;

                lblPedido2.Location = lblPedTemplate.Location;
                lblPedido2.Font = lblPedTemplate.Font;
                lblPedido2.Text = lblPedTemplate.Text;
                lblPedido2.BackColor = lblIdPedTemplate.BackColor;

                lblIdPedido2.Location = lblIdPedTemplate.Location;
                lblIdPedido2.Font = lblIdPedTemplate.Font;
                lblIdPedido2.Text = Diff.Rows[i - 1][0].ToString();
                lblIdPedido2.BackColor = Color.Transparent;


                lblEmail2.Location = lblEmailTemplate.Location;
                lblEmail2.Font = lblEmailTemplate.Font;
                lblEmail2.Text = Diff.Rows[i - 1][1].ToString();
                lblEmail2.BackColor = lblEmailTemplate.BackColor;
                lblEmail2.AutoSize = true;

                lblData2.Location = lblDatatemplate.Location;
                lblData2.Font = lblDatatemplate.Font;
                lblData2.Text = Diff.Rows[i - 1][2].ToString();
                lblData2.BackColor = lblDatatemplate.BackColor;
                lblData2.Anchor = lblDatatemplate.Anchor;
                lblData2.AutoSize = true;
            }
        }

        private void btnCalcIng_Click(object sender, EventArgs e)
        {
            /*pedido.getPedido(int.Parse()
            Conf_DetalhePed conf_DetalhePed = new Conf_DetalhePed();
            conf_DetalhePed.Show();*/
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
