using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classandform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btimc_Click(object sender, EventArgs e)
        {
            double peso;
            double altura;
            
            peso = double.Parse(txtpeso.Text);
            altura = double.Parse(txtaltura.Text);
            ImcClass pessoa1 = new ImcClass();
            ImcClass pessoa2 = new ImcClass(peso, altura);
            pessoa1.setaltura(altura);
            pessoa1.setpeso(peso);

            label3.Text = "O IMC é: " + pessoa1.IMC().ToString() + ". \r\n";
            double IMC = (peso / (altura * altura));
            if (IMC < 17)
            {
                label3.Text += "A pessoa está muito abaixo do peso";
            }
            else if (IMC >= 17 && IMC <= 18.49)
            {
                label3.Text += "A pessoa está abaixo do peso.";
            }
            else if (IMC >= 18.5 && IMC <= 24.99)
            {
                label3.Text += "A pessoa está no peso normal.";
            }
            else if(IMC >= 25 && IMC <= 29.99)
            {
                label3.Text += "A pessoa está acima do peso.";
            }
            else if (IMC >= 30 && IMC <= 34.99)	
            {
                label3.Text += "A pessoa está em uma obesidade I.";
            }
            else if (IMC >= 35 && IMC <= 39.99) 
            {
                label3.Text += "A pessoa está em uma obesidade II.";
            }
            else 
            {
                label3.Text += "A pessoa está em uma obesidade III.";
            }
		 
	




                /*Abaixo de 17	Muito abaixo do peso
                    Entre 17 e 18,49	Abaixo do peso
                    Entre 18,5 e 24,99	Peso normal
                    Entre 25 e 29,99	Acima do peso
                    Entre 30 e 34,99	Obesidade I
                    Entre 35 e 39,99	Obesidade II (severa)
                    Acima de 40	Obesidade III (mórbida)*/
            
        }
    }
}
