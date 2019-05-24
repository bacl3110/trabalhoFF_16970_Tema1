/*
*  -------------------------------------------------
* <copyright file=" Program " company="IPCA"/>
* <date> 5/24/2019 4:12:47 PM </date>
* <author> bruno 16970 </author>
* <email> a16970@alunos.ipca.pt </email>
* -------------------------------------------------
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double altInicial = 0, vlInicial = 0, angLanc = 0, desl = 0;
            int op = 1;
            string input;
            bool i = false;

            Console.WriteLine("Este programa pretende simular a situacao implicita no Tema 1 do trabalho de simulacao da disciplina de Fundamentos de Fisica.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Qual a altura inicial do lançamento?");
            while (i != true)
            {
                input = Console.ReadLine();
                i = double.TryParse(input, out altInicial);
                if (i == false) Console.WriteLine("Introduçao Invalida, tente novamente!");
            }
            i = false;
            Console.Clear();
            Console.WriteLine("Qual a velocidade inicial do lançamento?");
            while (i != true)
            {
                input = Console.ReadLine();
                i = double.TryParse(input, out vlInicial);
                if (i == false) Console.WriteLine("Introduçao Invalida, tente novamente!");
            }
            i = false;
            Console.Clear();
            Console.WriteLine("Qual o angulo do lançamento? (Em graus)");
            while (i != true)
            {
                input = Console.ReadLine();
                i = double.TryParse(input, out angLanc);
                if (i == false) Console.WriteLine("Introduçao Invalida, tente novamente!");
            }
            i = false;
            Console.Clear();
            while (op != 0)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1- Alcance do projetil");
                Console.WriteLine("2- Altura maxima atingida");
                Console.WriteLine("3- Altura atingida em função do deslocamento horizontal");
                Console.WriteLine("4- Velocidade em x em função do deslocamento horizontal");
                Console.WriteLine("5- Velocidade em y em função do deslocamento horizontal");
                Console.WriteLine("6- Velocidade Total em função do deslocamento horizontal");
                Console.WriteLine("0- Sair\n");
                while (i != true)
                {
                    input = Console.ReadLine();
                    i = int.TryParse(input, out op);
                    if (i == false) Console.WriteLine("Introduçao Invalida, tente novamente!");
                }
                i = false;
                Console.WriteLine();
                switch (op)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("O Alcance do projetil e de {0}m.", Function.AlcanceMax(altInicial, vlInicial, angLanc).ToString("0.##"));
                        Console.ReadLine();
                        break;
                    case 2:

                        Console.WriteLine("A altura maxima atingida e de {0}m.", Function.AltMax(altInicial, vlInicial, angLanc).ToString("0.##"));
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Qual o descolamento a analisar? (em metros)");
                        while (i != true)
                        {
                            input = Console.ReadLine();
                            i = double.TryParse(input, out desl);
                            if (i == false) Console.WriteLine("Introduçao Invalida, tente novamente!");
                        }
                        i = false;
                        if (desl < Function.AlcanceMax(altInicial, vlInicial, angLanc))
                        {
                            Console.WriteLine("A altura relativa ao deslocamento {0}m e de {1}m.", desl.ToString("0.##"), Function.AltX(desl, altInicial, vlInicial, angLanc).ToString("0.##"));
                        }
                        else
                        {
                            Console.WriteLine("O deslocamento inserido e superior ao alcance maximo de {0}m.", Function.AlcanceMax(altInicial, vlInicial, angLanc).ToString("0.##"));
                        }
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Qual o descolamento a analisar? (em metros)");
                        while (i != true)
                        {
                            input = Console.ReadLine();
                            i = double.TryParse(input, out desl);
                            if (i == false) Console.WriteLine("Introduçao Invalida, tente novamente!");
                        }
                        i = false;
                        if (desl < Function.AlcanceMax(altInicial, vlInicial, angLanc))
                        {
                            Console.WriteLine("A velocidade em x relativa ao deslocamento {0}m e de {1}m/s.", desl.ToString("0.##"), Function.VelX(vlInicial, angLanc).ToString("0.##"));
                        }
                        else
                        {
                            Console.WriteLine("O deslocamento inserido e superior ao alcance maximo de {0}m.", Function.AlcanceMax(altInicial, vlInicial, angLanc).ToString("0.##"));
                        }
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Qual o descolamento a analisar? (em metros)");
                        while (i != true)
                        {
                            input = Console.ReadLine();
                            i = double.TryParse(input, out desl);
                            if (i == false) Console.WriteLine("Introduçao Invalida, tente novamente!");
                        }
                        i = false;
                        if (desl < Function.AlcanceMax(altInicial, vlInicial, angLanc))
                        {
                            Console.WriteLine("A velocidade em y relativa ao deslocamento {0}m e de {1}m/s.", desl.ToString("0.##"), Function.VelY(desl, vlInicial, angLanc).ToString("0.##"));
                        }
                        else
                        {
                            Console.WriteLine("O deslocamento inserido e superior ao alcance maximo de {0}m.", Function.AlcanceMax(altInicial, vlInicial, angLanc).ToString("0.##"));
                        }
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Qual o descolamento a analisar? (em metros)");
                        while (i != true)
                        {
                            input = Console.ReadLine();
                            i = double.TryParse(input, out desl);
                            if (i == false) Console.WriteLine("Introduçao Invalida, tente novamente!");
                        }
                        i = false;
                        if (desl < Function.AlcanceMax(altInicial, vlInicial, angLanc))
                        {
                            Console.WriteLine("A velocidade total relativa ao deslocamento {0}m e de {1}m/s.", desl.ToString("0.##"), Function.VelTotal(desl, vlInicial, angLanc).ToString("0.##"));
                        }
                        else
                        {
                            Console.WriteLine("O deslocamento inserido e superior ao alcance maximo de {0}m.", Function.AlcanceMax(altInicial, vlInicial, angLanc).ToString("0.##"));
                        }
                        Console.ReadLine();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcao Invalida, prima enter para tentar novamente!\n");
                        Console.ReadLine();
                        break;
                }
                Console.Clear();
            }


            Console.WriteLine("O programa vai terminar! Clique enter para sair.");
            Console.Read();
        }
    }
}
