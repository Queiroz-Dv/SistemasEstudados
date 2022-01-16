using System;

namespace Treinojunior
{
    class TesteComplexoSwitch
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo ao teste de switch complexo");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Gostaria de ver um exemplo?" +
                              "\nDigite 1 para sim e 0 para não");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Digite qualquer número:");
                    int resp = int.Parse(Console.ReadLine());
                    if (resp == 0)
                    {
                        Console.WriteLine("Digite um número acima de 0");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Exemploinicial(resp);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                }
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Gostaria de testar o sistema?" +
                                  "\nDigite 1 para sim e 0 para não");
                int a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    Console.Clear();
                    ColetaDados(out int res, out int tot);
                    if (res == 0 || tot == 0)
                    {
                        Console.WriteLine("Número inválido. " +
                        "\nPor favor digite números acima de 0");
                    }
                    else
                    {
                        if (res < tot || res > tot)
                        {
                            for (int i = 0; i < tot; i++)
                            {
                                switch (res % 2)
                                {
                                    case 0:
                                        res = res + 5;
                                        break;
                                    default:
                                        res = res * 2;
                                        break;
                                }
                                Console.WriteLine("Resultado: " + res);
                            }
                        }

                        Console.WriteLine("Obrigado por me testar!" +
                                          "\nVolte sempre");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("Obrigado por me testar! Volte semnpre!");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }
        }

        private static void ColetaDados(out int res, out int tot)
        {
            Console.WriteLine("Digite um número para que eu possa testar:");
            res = int.Parse(Console.ReadLine());
            Console.WriteLine("Até quanto gostaria de contar?");
            tot = int.Parse(Console.ReadLine());
        }

        private static void Exemploinicial(int x)
        {
            int n = x;
            for (int i = 0; i < 20; i++)
            {
                switch (n % 2)
                {
                    case 0:
                        n = n + 5;
                        break;
                    default:
                        n = n * 2;
                        break;
                }
                Console.WriteLine("Resultado: " + n);
            }
        }
    }
}
