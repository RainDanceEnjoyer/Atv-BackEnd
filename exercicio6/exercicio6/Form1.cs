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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int Side = int.Parse(txtLados.Text);



            switch (Side)
            {
                case 3: lblResult.Text = "TRIANGULO"; break;
                case 4: lblResult.Text = "QUADRADO"; break;
                default: lblResult.Text = "????"; break; 



            }
        }
    }
}
