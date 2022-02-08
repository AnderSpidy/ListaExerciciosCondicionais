using System;

namespace Exercicio5
{
    internal class Program
    {
        /*Exercício 5:
            • Faça um algoritmo que leia dois valores inteiros A e B, 
            se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B.
            Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C 
            e mostrar seu conteúdo na tela.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A:");
            string strA = Console.ReadLine();
            int A = Convert.ToInt32(strA);
            Console.WriteLine("Digite o valor de B");
            string strB = Console.ReadLine();
            int B = Convert.ToInt32(strB);

            if (A == B)
            {
                int C = A + B;
                Console.WriteLine("Os valores são iguais, então SOMADOS o resultado é " + C);
            }
            else
            {
                int C = A * B;
                Console.WriteLine("Os valores são diferentes, então MULTIPLICADOS o resultado é " + C);
            }
            Console.ReadLine();
        }
    }
}
