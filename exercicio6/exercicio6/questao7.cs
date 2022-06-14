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
    public partial class questao7 : Form
    {
        public questao7()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            float height = float.Parse(txtHeight.Text);
            float weight = float.Parse(txtWeight.Text);
            double male = (weight * height) - 58;
            double female = (weight * height) - 44.7;
            char sex = char.Parse(txtSexo.Text);
           


            switch (sex)
            {
                case 'M':
                    
                        lblResult.Text = "peso ideal: " + male; 
                    break;
                case 'F':
                    lblResult.Text = "peso ideal: " + female; ;
                    break;
                default: 
                    lblResult.Text = "erro, digite apenas M ou F"; 
                    break;
                    


            }
        }
    }
}
