using System;

namespace Treinojunior
{
    class TesteComplexo
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao teste de if complexo!");
            Console.ReadKey();

            Console.WriteLine("Digite um número para que eu possa testar:");
            int x = int.Parse(Console.ReadLine());
            ColetaDados(x);
            Console.ReadKey();
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Gostaria de testar novamente?" +
                                  "Digite 1 para sim e 0 para não 1/0");
                int a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                        Console.Clear();
                        Console.WriteLine("Digite um número para que eu possa testar:");
                        int res = int.Parse(Console.ReadLine());
                        ColetaDados(res);
                        Console.WriteLine("Obrigado por me testar! Volte sempre");
                        Console.ReadKey();
                        Console.Clear();
                }
                else
                {
                    Console.WriteLine("Obrigado por me testar! Volte semnpre!");
                    Console.Clear();
                    break;
                }
            }
        }

        private static void ColetaDados(int x)
        {
            int n = x;
            for (int i = 0; n < 1000; i++)
            {
                if (n % 2 == 0)
                {
                    n = n + 5;
                }
                else
                {
                    n = n * 2;
                }
                Console.WriteLine(n);
            }
            Console.WriteLine("Resultado: " + n);
        }
    }
}
