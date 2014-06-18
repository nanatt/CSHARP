using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosAlgoritimos
{
    class Program
    {
        static void Main(string[] args)
        {
            double nmax=0;
            double nmin = 0;
            double[,] matriz = new double[4, 4];
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz.Length; j++)
                {
                    if (matriz[i, j] > nmax)
                    {
                        nmax = matriz[i, i];
                    }
                    else if (matriz[i, j] < nmin)
                    {
                        nmin = matriz[i, i];
                    }
                }
                
            }
            Console.WriteLine("Máximo: {0}", nmax);
            Console.WriteLine("Mínimo: {0}", nmin);
            Console.ReadKey();

        }
    }
}
