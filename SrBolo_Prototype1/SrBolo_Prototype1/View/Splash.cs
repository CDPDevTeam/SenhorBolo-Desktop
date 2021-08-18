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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int progr = 0;
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            guna2ProgressBar1.Value = progr;
            progr++;
            
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {
            if (guna2ProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                admHome login = new admHome();
                login.ShowDialog();
                this.Close();
            }
        }

        
    }
}
