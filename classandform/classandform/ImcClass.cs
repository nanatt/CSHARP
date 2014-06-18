using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classandform
{
    class ImcClass
    {
        private double peso;
        private double altura;
        private double imc;

        public ImcClass() { }
        public ImcClass(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }
        public void setpeso(double peso)
        {
            this.peso = peso;
            
        }
        public void setaltura(double altura)
        {
            this.altura = altura;
            
        }
        public double IMC()
        {
            return (peso / (altura * altura));
        }
    }
}
