using System;

namespace Treinojunior.ProjetosGrandes
{
    class MenuProjetosGrandes : MenuPrincipal
    {
        public MenuProjetosGrandes()
        {
            //Tamanho da tela
            Console.SetWindowSize(100, 20);
            //Nome de cima da tela
            Console.Title = "Menu Projetos de Grande Porte";
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static int Menu()
        {
            while (true)
            {
                Console.Clear();
                Centralizar("==== Bem Vindo ao Portfólio de Sistemas Queiroz ====\n");
                Centralizar("Hoje é " + DateTime.Now.ToLongDateString());
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Linha();
                Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 0. Voltar para projetos de pequeno porte <<        ||"));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 1. Sistema de Consumo de Energia                   ||"));
                Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                Linha();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("\n{0}", AlinhaTexto(36, "Escolha uma das opções de estudos realizados: ", "L"));
                try
                {
                    int valor = int.Parse(Console.ReadLine());
                    switch (valor)
                    {
                        case 0:
                            Console.Clear();
                            break;
                        case 1:
                            ConsumoEnergia.Menu();
                            continue;
                        default:
                            Centralizar("Opção inválida.");
                            Console.ReadKey();
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
