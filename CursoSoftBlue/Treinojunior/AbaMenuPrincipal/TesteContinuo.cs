using System;

namespace Treinojunior
{
    class TesteContinuo
    {
        public static void Menu()
        {
            //Limpa a tela anterior e testa o exemplo
            Console.Clear();
            Console.WriteLine("Bem-vindo ao Contador Contínuo!");
            Console.ReadKey();

            Console.WriteLine("Gostaria de ver um exemplo?" +
                             "\nDigite 1 para sim e 0 para não");
            int res = int.Parse(Console.ReadLine());
            if (res == 1)
            {
                //Se verdadeiro limpa a tela e chama o exemplo
                Console.Clear();
                ExemploInicial();
                Console.ReadKey();
                Console.WriteLine("Finalizado!");
                Console.ReadKey();
                Console.Clear();
            }
            //Senão, limpa a tela e testa o sistema
            Console.Clear();
            Console.WriteLine("Gostaria de contar também?" +
                              "\nDigite 1 para sim e 0 para não");
            int resp= int.Parse(Console.ReadLine());

            if (resp == 1)
            {
                //Se for sim, chama o método para coletar os números e testar o loop
                ColetaDados(out int numeroInicial, out int numeroFinal);
                if (numeroInicial <= numeroFinal)
                {
                    /*Para testes positivos usei o FOR pela facilidade de ser implementado
                      Segue a mesma lógica dos outros testes com diferença da continuidade
                      Se número digitado for menor ou igual que o numero final
                      então incrementamos o numero digitado.
                     */
                    for (int i = 0; numeroInicial <= numeroFinal; i++)
                    {
                        numeroInicial++;
                        Console.WriteLine(numeroInicial);

                    }
                    Console.WriteLine("Contagem finalizada!");
                    Console.ReadKey();
                    Console.WriteLine("O resultado foi: " + numeroInicial);
                    Console.WriteLine("Obrigado por me testar!");
                    Console.ReadKey();
                    Console.Clear(); 
                    //Finalizado o loop, limpa a tela e volta para o menu inicial.
                }
                else
                {
                    //Mas se o numero digitado for maior que o numero final então invertemos a ordem
                    Console.WriteLine("Você descobriu o modo secreto de decremento!");
                    Console.ReadKey();
                    Console.WriteLine("Nesse modo iremos contar diminuindo os números.");
                    Console.ReadKey();
                    //Para números negativos optaei pelo WHILE pela sua facilidade na implementação
                    /*Se numero digitado for maior ou igual ao numero final
                     então diminua o número inicial até obter o resultado.*/
                    while (numeroInicial>=numeroFinal)
                    {
                        numeroInicial--;
                        Console.WriteLine(numeroInicial);
                    }
                    Console.WriteLine("Contagem finalizada!");
                    Console.ReadKey();
                    Console.WriteLine("O resultado foi: " + numeroInicial);
                    Console.WriteLine("Obrigado por me testar!");
                    Console.ReadKey();
                    Console.Clear();
                    //Finalizando o processo apresento o resultado e encerramos o teste
                }
            }
            else
            {
                //Se nada for selecionado então encerramos o teste e voltamos ao menu principal.
                Console.WriteLine("Obrigado por me testar! Volte sempre!");
                Console.ReadKey();
                Console.Clear();
            }
        }

        //Método de coletar informações
        private static void ColetaDados(out int numeroInicial, out int numeroFinal)
        {
            Console.Clear();
            Console.WriteLine("Digite qual número você quer começar a contar:");
            numeroInicial = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite até que número você quer que eu conte:");
            numeroFinal = int.Parse(Console.ReadLine());
        }

        //Método de exemplo 
        private static void ExemploInicial()
        {
            Console.WriteLine("Agora irei contar até cem para você!");
            Console.ReadKey();
            for (int x = 0; x < 100; x++)
            {
                Console.WriteLine(x);
            }
        }
    }
}
