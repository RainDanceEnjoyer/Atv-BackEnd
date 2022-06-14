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
    public partial class atv5 : Form
    {
        public atv5()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (txtValT.Text == "" || txtValP.Text == "")
            {
                MessageBox.Show("Insira um valor válido");
            }
            
            float ValPaid = float.Parse(txtValP.Text);
            float ValTotal = float.Parse(txtValT.Text);
            float ValChange = ValTotal - ValPaid;
            
            
            if (ValTotal <= ValPaid)
            {
                MessageBox.Show("" + ValChange);


            }
            else if (ValTotal > ValPaid)
            {
                MessageBox.Show("Valor insuficiente; \n Devendo: " + ValChange);


            }
        }
    }
}
