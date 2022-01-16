using System;

namespace Treinojunior
{
    class TesteFatoracao
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao teste de fatorial!");
            Console.ReadKey();

            Console.WriteLine("Deseja ver um exemplo?" +
                              "\nDigite 1 para sim e 0 para não");
            int ex = int.Parse(Console.ReadLine());
            if (ex==1)
            {
                ExemploInicial();
            }
            
            Console.Clear();
            int val = ColetaDados();
            if (val != 0)
            {
                int ftr = 1;
                for (int i = 2; i <= val; i++)
                {
                    ftr *= i;
                    Console.WriteLine("Fator: " + ftr);
                }
                Console.WriteLine("O fatorial de " + val + " é igual a " + ftr);
                Console.ReadKey();

                Console.WriteLine("Fatoração finalizada!");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Digite 1 para voltar ao menu principal ou 0 para sair");
                int resp = int.Parse(Console.ReadLine());
                if (resp == 1)
                {
                    Console.Clear();
                    Menu();
                }
                else
                {
                    Console.WriteLine("Fechando Teste Fatorial");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Impossível fatorar 0");
                Console.ReadKey();
                Console.WriteLine("Voltando ao menu principal");
                Console.Clear();
                Menu();
            }
        }

        private static int ColetaDados()
        {
            Console.WriteLine("Digite o número que você deseja fatorar:");
            int val = int.Parse(Console.ReadLine());
            return val;
        }

        private static void ExemploInicial()
        {
            Console.WriteLine("Agora irei te mnostrar um exemplo do que eu faço!");
            Console.ReadKey();

            int fat = 1;
            int v = 6;
            for (int i = 2; i <= v; i++)
            {
                fat *= i;
                Console.WriteLine("Fator: " + fat);
            }
            Console.WriteLine("O fatorial de " + v + " é igual a " + fat);
            Console.ReadKey();
        }
    }
}
