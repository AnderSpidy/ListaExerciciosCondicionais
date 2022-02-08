using System;

namespace Exercicio1
{
    internal class Program
    {
      /*  Exercício 1:
        • Faça um algoritmo que leia os valores A, B, C e imprima na tela se a
        soma de A + B é menor que C.*/

        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 1:\n Digite o valor de A:");
            string strA = Console.ReadLine();
            Console.WriteLine("Digite o valor de B:");
            string strB = Console.ReadLine();
            Console.WriteLine("Digite o valor de C:");
            string strC = Console.ReadLine();

            int A = Convert.ToInt32(strA);
            int B = Convert.ToInt32(strB);
            int C = Convert.ToInt32(strC);

            int somaAB = A + B;
            if(somaAB > C)
            {
                Console.WriteLine("A Soma de entre A e B é maior que C. \n A + B = " + somaAB + "\n C = " + C);
            }
            else
            {
                Console.WriteLine("A Soma de entre A e B NÃO é maior que C. \n A + B = " + somaAB + "\n C = " + C);
            }
            Console.ReadLine();
        }
    }
}
