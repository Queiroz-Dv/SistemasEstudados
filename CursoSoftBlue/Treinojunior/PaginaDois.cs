using System;
using Treinojunior.AbaPaginaDois;
using Treinojunior.POO;
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
            Console.Title = "Queiroz Sistemas[v1.0]";
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
                Console.WriteLine("|{0}|", AlinhaTexto(35, "  =============================="));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 0. Voltar Página <<          ||"));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 1. Teste de Media            ||"));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 2. Banco Matemático          ||"));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 3. Matricula de aluno        ||"));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 4. Calcular Peso             ||"));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 10. Próxima página           ||"));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "  ============================== "));
                Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
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
                            EntradaBanco.Menu();
                            continue;
                        case 3:
                            MatriculaAluno.Menu();
                            continue;
                        case 4:
                            CalculoPesoIdeal.Menu();
                            continue;
                        case 10:
                            break;
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

