﻿using System;
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
            Funcionario func  = new Gerente();
            //bool check = usuario.Acessar(func,cbUser.SelectedItem.ToString(), txtLogin.ToString(), txtSenha.ToString());

            

            /*if (check == true)
            {
                
            } */
            //else { MessageBox.Show("Selecione um usuário", "ATENÇÃO"); }
            Adm_Home adm_Home = new Adm_Home();
            adm_Home.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
