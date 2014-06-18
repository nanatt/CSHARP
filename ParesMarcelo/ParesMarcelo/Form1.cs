using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParesMarcelo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] pares = new int[5];
            int x = 0;
            int y = int.Parse(txtY.Text);

            //verifica se o numero inicial txtX é par
            if ((int.Parse(txtX.Text) % 2) == 0)
            {
                x = int.Parse(txtX.Text);
            }
            else 
            {
                x = int.Parse(txtX.Text) + 1;
            }

            // loop de atribuição
             for (int i = 0; i < pares.Length; i++)
             {
                 if (x <= y)
                 {
                     pares[i] = x;
                     x += 2;
                 }
             }
            // loop de leitura usando foreach
            txtResult.Text = "Leitura do Array usando foreach \r\n";
            foreach (var par in pares)
	          {
		         txtResult.Text += par + " ";
	          }

        }
    }
}
