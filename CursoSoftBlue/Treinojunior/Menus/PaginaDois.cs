using System;
using Treinojunior.AbaPaginaDois;
using Treinojunior.POO;
using Treinojunior.ProjetosGrandes;
using Treinojunior.ProjetosMedios;
using Treinojunior.TestesBásicos;
using Treinojunior.TestesMatematicos.ModelosMedia;

namespace Treinojunior
{
    public class PaginaDois : MenuPrincipal
    {
        public PaginaDois()
        {
            //Tamanho da tela
            Console.SetWindowSize(100, 20);
            //Nome de cima da tela
            Console.Title = "Menu";
            Console.ForegroundColor = ConsoleColor.White;
        }

        public int Menu()
        {
            while (true)
            {
                Console.Clear();
                Centralizar("==== Bem Vindo ao Portfólio de Sistemas Queiroz ====\n");
                Centralizar("Hoje é " + DateTime.Now.ToLongDateString());
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Linha();
                Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "  =================================================="));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 0. Voltar Página <<                              ||"));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 1. Teste de Media                                ||"));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 2. Matricula de Aluno                            ||"));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 3. Calcular Peso                                 ||"));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 4. Projetos de Médio Porte >>                    ||"));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 5. Projetos Windows Form    >>                   ||"));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "  =================================================="));
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
                            MediaComum.Menu();
                            continue;
                        case 2:
                            MatriculaAluno.Menu();
                            continue;
                        case 3:
                            CalculoPesoIdeal.Menu();
                            continue;
                        case 4:
                            MenuProjetosMedios.Menu();
                            continue;
                        case 5:
                            ProjetosWindowsForms.Menu();
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

