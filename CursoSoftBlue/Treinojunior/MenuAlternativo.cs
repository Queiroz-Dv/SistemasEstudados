using System;
using Treinojunior.POO;
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
                string corpoMenu = "Olá usuário, bem vindo ao sistema de testes matemáticos!\n" +
                    "\n\n" +
                    "\n           Digite uma das opções abaixo:" +
                    "\n           0 - Voltar" +
                    "\n           1 - Teste de Media" +
                    "\n           2 - Banco Matemático";
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
