using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Triangulo triangulo_a = new Triangulo(int.Parse(txta.Text), int.Parse(txtb.Text), int.Parse(txtc.Text));
            label4.Text = triangulo_a.Construiu() + triangulo_a.verificatipo();
            

        }
    }
}
