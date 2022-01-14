using System;

namespace Treinojunior
{
    public class TesteTabuada
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("*o* Bem-vindo a Tabuada Inteligente *o* ");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Escolha uma das nossas opções abaixo:");
            string men = "\n" +
                   "\n           0 - Sair" +
                   "\n           1 - Multiplicação " +
                   "\n           2 - Adição" +
                   "\n           3 - Subtração" +
                   "\n           4 - Divisão" +
                   "\n           5 - Exemplo";
            Console.WriteLine(men);
            int Calc = int.Parse(Console.ReadLine());
            if (Calc == 1)
            {
                Multiplicar(out int numeroInicial, out int numeroCalc);
                if (numeroInicial < numeroCalc || numeroInicial > numeroCalc)
                {
                    Console.Clear();
                    Console.WriteLine("Tabauda de " + numeroInicial);

                    for (int i = 0; i < numeroCalc; i++)
                    {
                        int resultado = numeroInicial * i;
                        Console.WriteLine(numeroInicial + " x " + i + " = " + resultado);
                    }
                    Console.WriteLine("Tabuada Finalizada!");
                    Console.ReadKey();
                    Console.WriteLine("Obrigado por testar a minha multiplicação inteligente!");
                    Console.ReadKey();
                    Console.WriteLine("Voltando ao menu principal...");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                }
            }
            else if (Calc == 2)
            {
                Somar(out int numeroInicial, out int numeroCalc);
                if (numeroInicial < numeroCalc || numeroInicial > numeroCalc)
                {
                    Console.Clear();
                    Console.WriteLine("Tabauda de " + numeroInicial);

                    for (int i = 0; i < numeroCalc; i++)
                    {
                        int resultado = numeroInicial + i;
                        Console.WriteLine(numeroInicial + " + " + i + " = " + resultado);
                    }
                    Console.WriteLine("Tabuada Finalizada!");
                    Console.ReadKey();
                    Console.WriteLine("Obrigado por testar a minha adição inteligente!");
                    Console.ReadKey();
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal.");
                    Console.Clear();
                    Menu();
                }
            }
            else if (Calc == 3)
            {
                Subtracao(out int numeroInicial, out int numeroCalc);
                if (numeroInicial >= numeroCalc)
                {
                    Console.Clear();
                    Console.WriteLine("Tabauda de " + numeroInicial);

                    for (int i = 0; i < numeroCalc; i++)
                    {
                        int resultado = numeroInicial - i;
                        Console.WriteLine(numeroInicial + " - " + i + " = " + resultado);
                    }
                    Console.WriteLine("Tabuada Finalizada!");
                    Console.ReadKey();
                    Console.WriteLine("Obrigado por testar a minha subtração inteligente!");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                }
                else
                {
                    Console.WriteLine("Número digitado é menor que a quantidade de vezes para calcular.");
                    Console.ReadKey();
                    Console.WriteLine("Voltando ao menu principal...");
                    Console.Clear();
                    Menu();
                }
            }
            else if (Calc == 4)
            {
                Dividir(out int numeroInicial, out int numeroCalc);
                if (numeroInicial == 0 || numeroCalc == 0)
                {
                    Console.WriteLine("Impossível dividir por 0");
                    Console.ReadKey();
                    Console.WriteLine("Voltando ao menu principal...");
                    Console.Clear();
                }
                else if (numeroInicial < numeroCalc || numeroInicial > numeroCalc)
                {
                    Console.Clear();
                    Console.WriteLine("Tabauda de " + numeroInicial);

                    for (int i = 1; i < numeroCalc; i++)
                    {
                        int resultado = numeroInicial / i;
                        if (resultado == 1 || resultado == 2 || resultado == 0)
                        {
                            Console.WriteLine("Resultados entre o, 1 e 2 são ignorados");
                            break;
                        }
                        else
                        {
                            Console.WriteLine(numeroInicial + " / " + i + " = " + resultado);
                        }
                    }
                    Console.WriteLine("Tabuada Finalizada!");
                    Console.ReadKey();
                    Console.WriteLine("Obrigado por testar a minha divisão inteligente!");
                    Console.ReadKey();
                    Console.WriteLine("Voltando ao menu principal...");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();

                }
                Console.WriteLine("Obrigado por testar!");
                Console.ReadKey();
                Console.Clear();
            }
            else if (Calc == 5)
            {
                ExemploInicial();
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            else
            {
                Console.WriteLine("Obrigado por visitar o sistema!");
                Console.ReadKey();
                Console.Clear();
            }

        }

        private static void Dividir(out int numeroInicial, out int numeroCalc)
        {
            Console.WriteLine("Digite o número que deseja calcular:");
            numeroInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas vezes quer que calcule?");
            numeroCalc = int.Parse(Console.ReadLine());
        }

        private static void Subtracao(out int numeroInicial, out int numeroCalc)
        {
            Console.WriteLine("Digite o número que deseja calcular:");
            numeroInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas vezes quer que calcule?");
            numeroCalc = int.Parse(Console.ReadLine());
        }

        private static void Somar(out int numeroInicial, out int numeroCalc)
        {
            Console.WriteLine("Digite o número que deseja calcular:");
            numeroInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas vezes quer que calcule?");
            numeroCalc = int.Parse(Console.ReadLine());
        }

        private static void Multiplicar(out int numeroInicial, out int numeroCalc)
        {
            Console.WriteLine("Digite o número que deseja calcular:");
            numeroInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas vezes quer que calcule?");
            numeroCalc = int.Parse(Console.ReadLine());
        }

        private static void ExemploInicial()
        {
            Console.WriteLine("Agora irei calcular a multiplicação do número nove como exemplo");
            Console.ReadKey();
            Console.Clear();
            int t = 9;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + " x " + t + " = ");
                Console.WriteLine(i * t);
            }
        }
    }
}

