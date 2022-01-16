using System;
using Treinojunior.Base;
using Treinojunior.TestesBásicos;

namespace Treinojunior.AbaPaginaDois
{
    class CalculoPesoIdeal : MenuPrincipal
    {
        public CalculoPesoIdeal()
        {
            //Tamanho da tela
            Console.SetWindowSize(100, 20);
            //Nome de cima da tela
            Console.Title = "Cálculo Peso Ideal";
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static int Menu()
        {
            while (true)
            {
                Console.Clear();
                Centralizar("==== Bem Vindo ao Diário de Sistemas ====\n");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Linha();
                Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "  =============================="));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 0. Menu Principal <<         ||"));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 1. Calcular Peso Ideal       ||"));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "  ============================== "));
                Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("\n{0}", AlinhaTexto(36, "Digite o que deseja fazer: ", "L"));
                try
                {
                    int valor = int.Parse(Console.ReadLine());
                    switch (valor)
                    {
                        case 0:
                            Centralizar("Obrigado por testar meu sistema. Volte sempre!");
                            Centralizar("Pressione qualquer tecla para voltar ao menu principal");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 1:
                            Console.Clear();
                            BasePessoa pessoa = new BasePessoa();

                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Linha();
                            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                            Console.WriteLine("|{0}|", AlinhaTexto(35, " Qual o seu sexo: F | M "));
                            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                            Console.BackgroundColor = ConsoleColor.Black;
                            pessoa.Sexo = char.Parse(Console.ReadLine());
                            char sexo = pessoa.Sexo;

                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Linha();
                            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                            Console.WriteLine("|{0}|", AlinhaTexto(35, $" Digite o nome: {sexo}  "));
                            Console.WriteLine("|{0}|", AlinhaTexto(35, " Digite sua altura: "));
                            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                            Console.BackgroundColor = ConsoleColor.Black;
                            double altura = Convert.ToDouble(Console.ReadLine());

                            if (sexo == 'M')
                            {
                                double calc = (72.7 * altura) - 58;
                                int pesoIdeal = Convert.ToInt32(calc);
                                Centralizar($"Seu peso ideal é {pesoIdeal}");
                                Centralizar("Pressione qualquer tecla para voltrar ao menu principal.");
                                Console.ReadKey();
                                Console.Clear();
                                continue;

                            }
                            else if (sexo == 'F')
                            {
                                double calc = (62.1 * altura) - 44.7;
                                int pesoIdeal = Convert.ToInt32(calc);
                                Centralizar($"Seu peso ideal é {pesoIdeal}");
                                Centralizar("Pressione qualquer tecla para voltrar ao menu principal.");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            else
                            {
                                Centralizar("Selecione o sexo e informe a altura corretamente.");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        default:
                            Centralizar("Opção inválida");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                    }
                    return valor;
                }
                catch (FormatException)
                {

                    return 0;
                }
            }
        }
    }
}
