using System;

namespace Treinojunior
{
    class TesteFibo
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao teste de Fibonacci!");
            Console.ReadKey();

            Console.WriteLine("Gostaria de ver um exemplo?" +
                              "\nDigite 1 para sim ou 0 para não");
            int resp = int.Parse(Console.ReadLine());
            if (resp == 1)
            {
                ExemploInicial();
            }

            Console.Clear();
            Console.WriteLine("Gostaria de tentar com outro número? 1/0");
            int res = int.Parse(Console.ReadLine());

            if (res == 1)
            {
                int n = ColetaDados();
                int a = 1;
                for (int i = 0, j = 0; j <= n; j++)
                {
                    Console.WriteLine("Resultado: " + i);
                    i = i + a;
                    a = i - a;
                }
                Console.ReadKey();
                Console.WriteLine("Obrigado por me testar!");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Obrigado por me testar! Volte sempre.");
                Console.ReadKey();
                Console.Clear();
            }

        }

        private static int ColetaDados()
        {
            Console.WriteLine("Digite um número:");
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("Número inválido. Tente novamente");
                Console.ReadKey();
                Console.Clear();
            }
            return n;
        }

        private static void ExemploInicial()
        {
            Console.WriteLine("Veja o exemplo abaixo");
            Console.ReadKey();
            int f = 1;
            for (int i = 0, c = 0; c < 15; c++)
            {
                Console.WriteLine("Exemplo: " + i);
                i = i + f;
                f = i - f;
            }
            Console.ReadKey();
            Console.WriteLine("Exemplo finalizado, digite qualquer tecla para voltar ao menu principal");
            Console.ReadKey();
        }
    }
}
