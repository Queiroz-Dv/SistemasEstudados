using System;

namespace Treinojunior
{
    class TesteComplexoSwitch
    {
        public static void ComplexoSwitch()
        {
            Console.WriteLine("Bem-vindo ao teste complexo com switch");
            Console.ReadKey();

            //Primeiro teste
            Console.WriteLine("Digite um número para que eu possa calcular:");
            int x = int.Parse(Console.ReadLine());
            Calcular(x);
            Console.ReadKey();
            Console.Clear();


            //Pergunta se quer de novo
            Console.WriteLine("Cálculo finalizado! Digite 1 para sim ou 0 para não " +
                "se você quer calcular novamente ");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {

                Console.WriteLine("Digite um número para que eu possa calcular:");
                int res = int.Parse(Console.ReadLine());
                Calcular(res);
                Console.WriteLine("Finalizado! Agora preciso descansar, volte em breve!");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Obrigado por me testar! Volte sempre!");
                Console.Clear();
            }
        }

        private static void Calcular(int x)
        {
            int n = x;
            for (int i = 0; n < 1000; i++)
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
                Console.WriteLine("Valor atual: " + n);
            }
        }
    }
}
