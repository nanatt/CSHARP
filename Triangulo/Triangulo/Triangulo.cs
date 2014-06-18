using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Triangulo
    {
        private int a;
        private int b;
        private int c;
        bool triangulo = false;

        public Triangulo() { }
        public Triangulo(int a, int b, int c)
        {
            //Condição de existência de um Triângulo
            //|b-c| < a < b + c
            this.triangulo = (Math.Abs(b - c) < a) & a < (b + c);
            if (triangulo)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }
        public string Construiu()
        {
            if (triangulo)
            {
                return "Os lados dos triângulos são: a = " + a + ", b = " + b + " e c = " + c;
            }
            else
            {
                return "Os valores informados não correspondem a um triângulo.";
            }
        }
        public string verificatipo()
        {
            if (a == b || a == c || b == c)
            {
                return ". Triângulo é Isósceles.";
            }
            else if (a == b && b == c)
            {
                return ". Triângulo é Equilátero.";
            }
            else
            {
                return ". Triângulo é Escaleno.";
            }
        }
    }

}
