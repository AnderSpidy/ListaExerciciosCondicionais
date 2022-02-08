using System;

namespace Exercicio4
{
    internal class Program
    {
        //Exercício 4:
        //• Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero:");
            string strnumero = Console.ReadLine();
            int numero = Convert.ToInt32(strnumero);

            int restNumero = numero % 2;
            if(restNumero == 0)
            {
                Console.WriteLine(" O numero " + numero + " é PAR!!!");
            }
            else
            {
                Console.WriteLine(" O numero " + numero + " é ÍMPAR!!!");
            }
            Console.ReadLine();
        }
    }
}
