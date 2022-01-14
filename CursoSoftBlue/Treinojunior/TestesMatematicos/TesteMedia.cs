using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinojunior.TestesMatematicos.ModelosMedia;

namespace Treinojunior.TestesMatematicos
{
    class TesteMedia
    {
        public const int VOLTAR = 0;
        public const int MEDIA_COMUM = 1;
        public const int MEDIA_PERSONALIZADO = 2;
        public static void Media()
        {
            while (true)
            {
                string corpoMenu = "Olá usuário, bem vindo ao sistema de Média \n" +
                    "\n\n" +
                    "\n           Digite o que deseja fazer abaixo:" +
                    "\n           0 - Voltar" +
                    "\n           1 - Teste de Media Comum" +
                    "\n           2 - Teste de Media Personalizado";
                Console.WriteLine(corpoMenu);
                int res = int.Parse(Console.ReadLine());

                if (res == 0)
                {
                    MenuAlternativo.MontarMenu();
                }
                else if (res == 1)
                {
                    MediaComum.Executar();
                }
                else if (res == 2)
                {
                    MediaPersonalizado.Executar();
                }
            }
        }
    }
}
