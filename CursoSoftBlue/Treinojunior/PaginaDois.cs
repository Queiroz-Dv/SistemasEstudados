using System;
using Treinojunior.POO;
using Treinojunior.TestesBásicos;
using Treinojunior.TestesMatematicos.ModelosMedia;

namespace Treinojunior
{
    class PaginaDois : MenuPrincipal
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
            Console.Clear();
            Centralizar("==== Bem Vindo ao Diário de Sistemas ====\n");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Linha();
            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
            Console.WriteLine("|{0}|", AlinhaTexto(35, "  =============================="));
            Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 0. Voltar Página <<          ||"));
            Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 1. Teste de Media            ||"));
            Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 2. Banco Matemático          ||"));
            Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 3. Matricula de aluno        ||"));
            Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 10. Próxima página           ||"));
            Console.WriteLine("|{0}|", AlinhaTexto(35, "  ============================== "));
            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n{0}", AlinhaTexto(36, "Escolha uma das opções de estudo : ", "L"));
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
                        break;
                    case 2:
                        EntradaBanco.Menu();
                        break;
                    case 3:
                        MatriculaAluno.Menu();
                        break;
                    case 10:
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        Console.ReadKey();
                        break;
                }
                return valor;
            }
            catch (FormatException)
            {
                return 0;
            }


            /* Console.Clear();
             string corpoMenu =
                 "  ===================================================================" +
                 "\n||    Olá usuário, bem vindo ao sistema de testes matemáticos!    ||" +
                 "\n||================================================================||" +
                 "\n||       |||||||    Digite uma das opções abaixo    |||||||       ||" +
                 "\n||================================================================||" +
                 "\n||    °      °   ||0 - Voltar Página                ||   °   °    ||" +
                 "\n||  °   °  °   ° ||1 - Teste de Media               || °   °   °  ||" +
                 "\n||    °      °   ||2 - Banco Matemático             ||   °   °    ||" +
                 "\n||       °       ||3 - Exemplo de mátricula de aluno|| °   °   °  ||" +
                 "\n||     °   °     ||10 - Próxima página              ||   °   °    ||" +
                 "\n||       °       ||=================================||     °      ||" +
                 "\n===================================================================";

             if (res == 0)
             {
                 Console.Clear();
                 break;
             }
             else if (res == 1)
             {
                 MediaComum.Menu();
             }
             else if (res == 2)
             {
                 EntradaBanco.Entre();
             }
             else if (res == 3)
             {
                 MatriculaAluno.Menu();
             }
             else
             {
                 Console.WriteLine("Opção inválida.");
                 Console.ReadKey();
                 continue;
             }
         }*/

        }
    }
}

