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
using System.Windows.Forms.DataVisualization.Charting;
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
            //graficoVendas.DataBindTable();
            addGrafico();
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
            dgrMaisVendidos.Columns[0].Width = (int)0.8 * dgrMaisVendidos.Width;
            dgrMaisVendidos.Columns[1].Width = (int)0.2 * dgrMaisVendidos.Width;
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

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void addGrafico()
        {
            // chartArea
            ChartArea chartArea = new ChartArea();
            graficoVendas.ChartAreas[0].Axes[0].MajorGrid.Enabled = false;//x axis
            graficoVendas.ChartAreas[0].AxisY.LabelStyle.Format = ".";
            //chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, 13);
            graficoVendas.ChartAreas[0].AxisX.Interval = 1;
            graficoVendas.ChartAreas[0].Axes[1].MajorGrid.Enabled = true;//y axis

            //Series
            Series series1 = new Series();
            graficoVendas.Series.Add(series1);
            //Series style
            series1.ChartType = SeriesChartType.Column;  // type
            series1.BorderWidth = 1;
            
            series1.Color = Color.FromArgb(11, 186, 179);
            series1.YValueType = ChartValueType.Double;
            series1.XValueType = ChartValueType.Double;
            
            
            

            
            int x = 0;
            object[,] valor = produto.GetMesVendas();
            string[] strdata = new string[3];
            int pos = 6;

            for (int i = 0; i < 8; i++)
            {
                
                strdata = valor[i, 1].ToString().Split('-');
                DateTime data = new DateTime(int.Parse(strdata[0]), int.Parse(strdata[1]), int.Parse(strdata[2]));
                string mes = "";
                switch (data.Month)
                {
                    case 1: mes = "Jan"; break;
                    case 2: mes = "Fev"; break;
                    case 3: mes = "Mar"; break;
                    case 4: mes = "Abr"; break;
                    case 5: mes = "Mai"; break;
                    case 6: mes = "jun"; break;
                    case 7: mes = "Jul"; break;
                    case 8: mes = "Ago"; break;
                    case 9: mes = "Set"; break;
                    case 10: mes = "Out"; break;
                    case 11: mes = "Nov"; break;
                    case 12: mes = "Dez"; break;


                }
                series1.Points.AddXY(pos,Convert.ToDouble(valor[i,0]));
                series1.Points[i].Label = "R$"+valor[i,0].ToString();
                CustomLabel monthLabel = new CustomLabel(pos-1, pos+1, mes, 0, LabelMarkStyle.None);
                graficoVendas.ChartAreas[0].AxisX.CustomLabels.Add(monthLabel);
                series1.Points[i].Font = new Font("Raleway", 9, FontStyle.Regular);
                pos--;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
