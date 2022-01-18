using System;

namespace Treinojunior.ProjetosMedios
{
    class MenuProjetosMedios : MenuPrincipal
    {
        public MenuProjetosMedios()
        {
            //Tamanho da tela
            Console.SetWindowSize(100, 20);
            //Nome de cima da tela
            Console.Title = "Projetos de Médio Porte";
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
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 1. Calcular Salário                                ||"));
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
                            CalculoSalario.Menu();
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
