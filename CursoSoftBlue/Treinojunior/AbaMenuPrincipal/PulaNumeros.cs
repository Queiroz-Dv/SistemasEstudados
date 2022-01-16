using System;

namespace Treinojunior
{
    class PulaNumero
    {
        public static void Menu()
        {
            //Limpa tela anterior e pergunta se quer testar o exemplo
            Console.Clear();
            Console.WriteLine("Bem-vindo ao teste de pular números!");
            Console.ReadKey();
            Console.WriteLine("Gostaria de ver um exemplo?" +
                              "\nDigite 1 para sim ou 0 para não");
            int ex = int.Parse(Console.ReadLine());
            if (ex == 1)
            {
                ExemploInicial();
                Console.WriteLine("Digite alguma tecla para continuar!");
                Console.ReadKey();
                Console.Clear();
            }

            //Limpa exemplo ou a área de início e pergunta se quer testar o sistema
            Console.Clear();
            Console.WriteLine("Gostaria de contar também? " +
                              "\nDigite 1 para sim e 0 para não");
            int res = int.Parse(Console.ReadLine());
            if (res == 1)
            {
                Console.Clear();
                //Chama o método passando os parâmetros e colentando os dados de retorno
                ColetaDados(out int numeroInicial, out int pulaNumero, out int numeroDestino);
                if (numeroInicial <= numeroDestino)
                {
                    /*Se o numero digitado for menor que o numero final entãoentra no loop
                     * Saindo do loop mostra o resultado e saí do sistema indo para a tela inicial*/
                    for (int x = 0; numeroInicial < numeroDestino; x++)
                    {

                        numeroInicial = numeroInicial + pulaNumero;
                        Console.WriteLine(numeroInicial);
                    }
                    Console.WriteLine("O resultado foi:" + numeroInicial);
                    Console.ReadKey();
                    Console.WriteLine("Contagem finalizada!" +
                                      "\nAgora preciso descansar." +
                                      "\nVolte em breve!");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    //Caso contrário ativamos o modo decremento que é o inverso
                    Console.WriteLine("Você descobriu o modo secreto de decremento!");
                    Console.ReadKey();
                    Console.WriteLine("Iremos contar diminuindo os números!");
                    Console.ReadKey();
                    Console.Clear();

                    /*A lógica aqui teve de ser diferente e por isso optei pelo while
                     Neste caso, se o número digitado for maior que o número final, 
                     então pegamos o numero que pula e decrementa do numero inicial para chegar ao resultado*/
                    while (numeroInicial > numeroDestino)
                    {
                        numeroInicial = numeroInicial - pulaNumero;
                        Console.WriteLine(numeroInicial);
                    }
                    //Saindo do loop mostramos o resultado e voltamos para a tela inicial 
                    Console.WriteLine("O resultado foi:" + numeroInicial);
                    Console.ReadKey();
                    Console.WriteLine("Contagem finalizada!" +
                                      "\nAgora preciso descansar." +
                                      "\nVolte em breve!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                //Caso não seja escolhido nada saímos para a tela inicial
                Console.WriteLine("Obrigado por me testar! " +
                                  "\nVolte em breve!");
                Console.ReadKey();
                Console.Clear();
            }
        }

        //Método que pega as informações
        private static void ColetaDados(out int numeroInicial, out int pulaNumero, out int numeroDestino)
        {
            Console.WriteLine("Digite o número a ser contado:");
            numeroInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite de quanto em quanto quer que eu conte?");
            pulaNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite até quanto quer que eu conte: ");
            numeroDestino = int.Parse(Console.ReadLine());
        }

        //Método de exemplo
        private static void ExemploInicial()
        {
            Console.WriteLine("Agora irei contar para você como exemplo");
            Console.ReadKey();
            for (int x = 1; x < 100; x += 2)
            {
                Console.WriteLine(x);
            }
        }
    }
}
