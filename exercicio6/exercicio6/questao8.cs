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
    public partial class questao8 : Form
    {
        public questao8()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {

           
            char sex = char.Parse(txtSexo.Text);
            
           
            if (sex == ' ')
            {
                MessageBox.Show("ERRO");



            }
            else
            {

                if (sex != 'F')
                {
                    MessageBox.Show("SO PODE MULHER");



                }
                else
                {
                    MessageBox.Show("OBRIGADO POR UTILIZAR");


                }

            }
        }
    }
}
