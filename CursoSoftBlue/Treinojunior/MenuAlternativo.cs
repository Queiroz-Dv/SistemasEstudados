using System;
using Treinojunior.POO;
using Treinojunior.TestesBásicos;
using Treinojunior.TestesMatematicos;
using Treinojunior.TestesMatematicos.ModelosMedia;

namespace Treinojunior
{
    class MenuAlternativo
    {
        public static void Menu()
        {

            while (true)
            {
                Console.Clear();
                string corpoMenu = 
                    "  ===================================================================" +
                    "\n||    Olá usuário, bem vindo ao sistema de testes matemáticos!    ||" +
                    "\n||================================================================||" +
                    "\n||       |||||||    Digite uma das opções abaixo    |||||||       ||" +
                    "\n||================================================================||" +
                    "\n||================================================================||" +
                    "\n||    °      °   ||0 - Voltar                       ||   °   °    ||" +
                    "\n||  °   °  °   ° ||1 - Teste de Media               || °   °   °  ||" +
                    "\n||    °      °   ||2 - Banco Matemático             ||   °   °    ||" +
                    "\n||       °       ||3 - Exemplo de mátricula de aluno|| °   °   °  ||" +
                    "\n||     °   °     ||10 - Próxima página              ||   °   °    ||" +
                    "\n||       °       ||=================================||     °      ||" +
                    "\n===================================================================";
                Console.WriteLine(corpoMenu);
                int res = int.Parse(Console.ReadLine());

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
            }
        }
    }
}
