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

namespace SrBolo_Prototype1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            

            //temporário

            LoginDAO usuario = new LoginDAO();
            bool check = usuario.Acessar(cbUser.SelectedItem.ToString(), txtLogin.Text, txtSenha.Text);

            

            if (check)
            {
                if(cbUser.SelectedItem.ToString() == "gerente"){
                    Adm_Home adm_Home = new Adm_Home();
                    adm_Home.Show();
                    this.Hide();
                }
                else if (cbUser.SelectedItem.ToString() == "confeiteiro")
                {
                    Conf_home conf_Home = new Conf_home();
                    conf_Home.Show();
                    this.Hide();
                }
                else if (cbUser.SelectedItem.ToString() == "caixa")
                {
                    Balc_Caixa balc_Caixa = new Balc_Caixa();
                    balc_Caixa.Show();
                    this.Hide();
                }
            } 
            else { MessageBox.Show("CPF ou senha incorretos.", "ATENÇÃO"); }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            if (txtLogin.Text.Length == 3 || txtLogin.Text.Length == 7)
            {
                txtLogin.Text += ".";
            }
            else if (txtLogin.Text.Length == 11)
            {
                txtLogin.Text += "-";
            }
            txtLogin.SelectionStart = txtLogin.Text.Length;
            txtLogin.SelectionLength = 0;
        }
    }
}
