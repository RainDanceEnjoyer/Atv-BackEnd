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
    public partial class atv10 : Form
    {
        public atv10()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            float weight = float.Parse(txtWeight.Text);
            float height = float.Parse(txtHeight.Text);
            float total = weight / (height * height);

            if (total < 18.5)
            {
                MessageBox.Show("Abaixo do peso");
            }

            else if (total > 18.5 && total < 25)
            {
                MessageBox.Show("Boa, peso ideal");

            }
            else if (total > 25 && total < 30)
            {
                MessageBox.Show("Acima do peso");

            }

            else
            {
                MessageBox.Show("Morbiusly Obese");

            }
        }
    }
}
