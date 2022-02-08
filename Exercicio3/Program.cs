using System;

namespace Exercicio3
{
    internal class Program
    {
        /*Exercício 3:
            • O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre a condição de peso de uma pessoa adulta.

            • A fórmula é IMC = peso / (altura) ²

            • Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição de acordo com a tabela abaixo.

        IMC em adultos Condição
        Abaixo de 18,5
        Abaixo do peso
        Entre 18,5 e 25 Peso normal
        Entre 25 e 30
        Acima do peso
        Acima de 30 obeso*/
        static void Main(string[] args)
        {
            Console.WriteLine("Ola! \n Calcular IMC!!!\n Digite o peso:");
            string strPeso = Console.ReadLine();
            float peso = Convert.ToSingle(strPeso);
            Console.WriteLine("Digite a sua altura:");
            string strAltura = Console.ReadLine();
            float altura = Convert.ToSingle(strAltura);

            float calculoIMC = peso / (altura * altura);

            if (calculoIMC < 18.5)
            {
                Console.WriteLine("\n--------------------\nSeu IMC é de " + calculoIMC + " e de acordo com os calculos," +
                    " abaixo de 18,5 é ABAIXO DO PESO\n--------------------");
            }
            else if (calculoIMC >= 18.5 && calculoIMC < 25)
            {
                Console.WriteLine("\n--------------------\nSeu IMC é de " + calculoIMC + " e de acordo com os calculos," +
                    " entre 18,5 e 25 é PESO NORMAL");
            }
            else if (calculoIMC >= 25 && calculoIMC < 30)
            {
                Console.WriteLine("\n--------------------\nSeu IMC é de " + calculoIMC + " e de acordo com os calculos," +
                    " entre 25 e 30 é ACIMA DO PESO");
            }
            else if (calculoIMC >= 30)
            {
                Console.WriteLine("\n--------------------\nSeu IMC é de " + calculoIMC + " e de acordo com os calculos," +
                    " acima de 30 é OBESO");
            }

            Console.ReadLine();
        }
    }
}
