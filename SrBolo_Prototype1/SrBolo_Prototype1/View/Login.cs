using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            switch (cbUser.SelectedIndex)
            {
                case 0:
                    Balc_Caixa caixa = new Balc_Caixa();
                    caixa.Show();
                    this.Close();
                    break;
                case 1:
                    View.Adm_Home admin = new View.Adm_Home();
                    admin.Show();
                    this.Close();
                    break;
                case 2:
                    Conf_home confeiteiro = new Conf_home();
                    confeiteiro.Show();
                    this.Close();
                    break;
                default:
                    MessageBox.Show("Selecione um usuário", "ATENÇÃO");
                    break;
            }
            

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
