using System;

namespace Treinojunior
{
    class TesteSequencial
    {
        public static void Menu()
        {
            //Limpar menu anterior e chama um exemplo do sistema
            Console.Clear();
            Console.WriteLine("Bem-vindo ao contador sequencial");
            Console.ReadKey();
            ExemploInicio();

            //Modo para limpar a tela antes de testar
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();

            //Loop de interação com usuário
            while (true)
            {
                //Captura informaçãoe testa a reposta
                Console.WriteLine("Gostaria de contar?" +
                                  "\nDigite 1 para sim e 0 para não");
                Console.WriteLine("1/0");
                int res = int.Parse(Console.ReadLine());
                Console.Clear();
                if (res == 1)
                {
                    /*Se for verdadeira chama o método para contar passando os parâmetros de saída
                      antes fazemos o teste: se o numero digitado for mmaior que o numero final iremos ativar o modo decremento
                     */
                    ColetaDados(out int numero, out int numeroFinal);
                    if (numero >= numeroFinal)
                    {

                        Console.WriteLine("Esse é o modo secreto de decremento!");
                        Console.ReadKey();
                        Console.WriteLine("Iremos contar diminuindo os números!");
                        Console.ReadKey();
                        while (numero >= numeroFinal)
                        {
                            numero = --numero;
                            Console.WriteLine(numero);
                        }
                        Console.WriteLine("O resultado foi: " + numero);
                        Console.ReadKey();
                        Console.WriteLine("Finalizado");
                        Console.Clear();
                    }
                    //Se der certo faz o loop e mostra resultado depois saí do loop
                    else
                    {
                        while (numero < numeroFinal)
                        {
                            numero = ++numero;
                            Console.WriteLine(numero);
                        }
                        Console.WriteLine("O resultado foi: " + numero);
                        Console.ReadKey();
                        Console.WriteLine("Finalizado!");
                        Console.Clear();
                    }
                }
                //Se não for escolhido sai do loop e volta para o menu principal
                else
                {
                    Console.WriteLine("Obrigado por testar! Volte sempre!");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

            }
        }

        //Método de contar Incremento
        private static void ColetaDados(out int numero, out int numeroFinal)
        {
            Console.WriteLine("Digite um número que queira ser contado: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Até quanto você quer que eu conte?");
            numeroFinal = int.Parse(Console.ReadLine());
        }

        //Método de exemplo
        private static void ExemploInicio()
        {
            Console.WriteLine("Agora eu irei contar de 10 a 25 como exemplo");
            Console.ReadKey();
            int n = 10;
            while (n <= 24)
            {
                n++;
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
