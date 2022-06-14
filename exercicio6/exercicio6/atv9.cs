using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio6
{
    public partial class atv9 : Form
    {
        public atv9()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            float num = float.Parse(txtNum.Text);
            if (num == 0)
            {
                MessageBox.Show("Nulo");

            }
            else if (num < 0)
            {
                MessageBox.Show("Negativo"); 



            }
            else
            {

                MessageBox.Show("Positivo");
            }
        }
    }
}
