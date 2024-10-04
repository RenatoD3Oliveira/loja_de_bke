using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loja.view
{
    public partial class bikes : Form
    {
        public bikes()
        {
            InitializeComponent();
        }

        private void bike2(object sender, EventArgs e)
        {
            bike2 bike2 = new bike2();
            this.Visible = false;
            bike2.ShowDialog();
            this.Visible = false;
        }

        private void bike1(object sender, EventArgs e)
        {
            bike1 bike1 = new bike1();
            this.Visible = false;
            bike1.ShowDialog();
            this.Visible = false;
        }

        private void engate(object sender, EventArgs e)
        {
            bike3 bike3 = new bike3();
            this.Visible = false;
            bike3.ShowDialog();
            this.Visible = false;
        }

        private void bike4(object sender, EventArgs e)
        {
            bike4 bike4 = new bike4();
            this.Visible = false;
            bike4.ShowDialog();
            this.Visible = false;
        }
    }
}
