using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Defina o tamanho da matriz: ");
            int tam = int.Parse(Console.ReadLine());
            double[,] matriz = new double[tam, tam];

            double num = 0;
            double soma = 0;
            double soma1 = 0;
            double media = 0;

            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    Console.WriteLine("Digite os números que deseja colocar dentro da matriz: ");
                    num = double.Parse(Console.ReadLine());
                    matriz[i, j] = num;
                }
            }
            for (int i = 0; i < tam; i++)
            {
                 soma += matriz[i, i];                
            }
            Console.WriteLine("A soma da diagonal principal é: " + soma);
            
            for (int j = tam-1; j >= 0; j--)
                {
                    soma1  += matriz[(tam-j-1), j];                     
                }

            /*FORMA ACRESCENTANDO
             * for(int i =0; i < tam; i++)
             * {
             *      soma+=matriz[i,(tam-i-1)];
             * }
             * 
             * OBS => Quadro: 
             * [0,2] = [0,tamanho-1] ====> tam-i
             * [1,1] = [0,tamanho-2] ====> tam-i-1
             * [2,0] = [0,tamanho-3] ====> tam-i-2
             */



            Console.WriteLine("A soma da diagonal secundária é: " + soma1);

            Console.ReadKey();
        }
        
    }
}
