using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinojunior.POO;
using Treinojunior.TestesMatematicos;

namespace Treinojunior
{
    class MenuAlternativo
    {
        public static void MontarMenu()
        {
            while (true)
            {
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
                    TesteMedia.Media();
                }
                else if (res == 2)
                {
                    EntradaBanco.Entre();
                }
            }
        }
    }
}
