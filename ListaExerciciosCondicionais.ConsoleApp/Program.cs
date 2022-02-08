using System;

namespace Exercicio2
{
    internal class Program
    {
      /*  Exercício 2:
        • Escreva um algoritmo que leia três valores inteiros e diferentes e
        mostre-os em ordem decrescente.*/
        static void Main(string[] args)
        {
            
            Console.WriteLine("Exercicio 2! Digite tres valores distintos \n Digite o primeiro valor:");
            string strPrimeiro = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor:");
            string strSegundo = Console.ReadLine();
            Console.WriteLine("Digite o terceiro valor:");
            string strTerceiro = Console.ReadLine();

            string mensagemEmTela = "";

            int primeiro = Convert.ToInt32(strPrimeiro);
            int segundo = Convert.ToInt32(strSegundo);
            int terceiro = Convert.ToInt32(strTerceiro);


           if (primeiro > segundo && primeiro > terceiro)
            {
                string Maior = primeiro.ToString();
                mensagemEmTela = Maior; 
            }
            else if (segundo > primeiro && segundo > terceiro)
            {
                string Maior = segundo.ToString();
                mensagemEmTela = Maior;
            }
            else if (terceiro > primeiro && terceiro > segundo)
            {
                string Maior = terceiro.ToString();
                mensagemEmTela = Maior;
            }
            
            //If para encontrar o maior numero
            if (primeiro > segundo && primeiro < terceiro)
            {
                string Medio = primeiro.ToString();
                mensagemEmTela += " | " + Medio;
            }
            else if (primeiro > terceiro && primeiro < segundo)
            {
                string Medio = primeiro.ToString();
                mensagemEmTela += " | " + Medio;
            }
            //------------------------------------
            //If para encontrar o numero medio 
            else if (segundo > primeiro && segundo < terceiro)
            {
                string Medio = segundo.ToString();
                mensagemEmTela += " | " + Medio;
            }
            else if (segundo > terceiro && segundo < primeiro)
            {
                string Medio = segundo.ToString();
                mensagemEmTela += " | " + Medio;
            }
            
            else if (terceiro > primeiro && terceiro < segundo)
            {
                string Medio = terceiro.ToString();
                mensagemEmTela += " | " + Medio;
            }
            else if (terceiro > segundo && terceiro < primeiro)
            {
                string Medio = terceiro.ToString();
                mensagemEmTela += " | " + Medio; 
            }
            //-------------------------------------
            //If para encontrar o numero Menor
            if(primeiro<segundo && primeiro < terceiro)
            {
                string Menor = primeiro.ToString();
                mensagemEmTela += " | " + Menor;
            }
            else if (segundo < primeiro && segundo < terceiro)
            {
                string Menor = segundo.ToString();
                mensagemEmTela += " | " + Menor;
            }
            else if (terceiro < primeiro && terceiro < segundo)
            {
                string Menor = terceiro.ToString();
                mensagemEmTela += " | " + Menor;
            }

            
            Console.WriteLine("\nDo numero maior para o menor " + mensagemEmTela);
            Console.ReadLine();
        }
    }
}
