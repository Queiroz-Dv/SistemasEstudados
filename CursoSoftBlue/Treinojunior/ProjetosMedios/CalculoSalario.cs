using System;


namespace Treinojunior.ProjetosMedios
{
    class CalculoSalario : MenuPrincipal
    {
        public CalculoSalario()
        {
            //Tamanho da tela
            Console.SetWindowSize(100, 20);
            //Nome de cima da tela
            Console.Title = "Queiroz Sistemas[v1.0]";
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
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 0. Voltar  <<               || "));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 1. Calcular Salario         || "));
                Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                Linha();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("\n{0}", AlinhaTexto(36, "Digite o que deseja fazer: ", "L"));
                try
                {
                    //Coleta os dados do menu principal
                    int valor = int.Parse(Console.ReadLine());
                    switch (valor)
                    {
                        case 0:
                            //Sai do programa
                            Centralizar("Obrigado por testar meu sistema. Volte sempre!");
                            Centralizar("Pressione qualquer tecla para voltar ao menu principal");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 1:
                            // Executa os procedimentos

                            if (true)
                            {
                                //Se algo não der certo volta ao menu
                                Centralizar("Pressione qualquer tecla para voltrar ao menu principal.");
                                Console.ReadKey();
                                Console.Clear();
                                continue;

                            }
                            else if (true)
                            {
                                //Senão testa outro procedimento
                                Centralizar("Pressione qualquer tecla para voltrar ao menu principal.");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            else
                            {
                                //Caso algo não saia como esperado
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        default:
                            //Para opções fora de contexto
                            Centralizar("Opção inválida");
                            Console.ReadKey();
                            Console.Clear();
                            continue;
                    }
                    //valor do menu de acesso
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
