using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinojunior.TestesMatematicos.ModelosMedia
{
    class MediaComum
    {
        public const int VOLTAR = 0;
        public const int TESTAR = 1;
        public const int LIMPAR = 2;
        public static void Executar()
        {
            while (true)
            {
                string corpoMenu = "Olá usuário, bem vindo ao sistema de Média Comum \n" +
                    "\n\n" +
                    "\n           Digite o que deseja fazer abaixo:" +
                    "\n           0 - Voltar" +
                    "\n           1 - Teste de Media Comum" +
                    "\n           2 - Limpar";
                Console.WriteLine(corpoMenu);
                int res = int.Parse(Console.ReadLine());

                if (res == 0)
                {
                    TesteMedia.Media();
                }
                else if (res == 1)
                {
                    double md;
                    Console.WriteLine("Digite a primeira nota: ");
                    double n1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a segunda nota: ");
                    double n2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a terceira nota: ");
                    double n3 = double.Parse(Console.ReadLine());

                    if (n1 == -1 || n2 == -1 || n3 == -1)
                    {
                        Console.WriteLine("Números inválidos. Digite novamente");
                    }
                    else
                    {
                        md = (n1 + n2 + n3) / 3;

                        if (md < 5)
                        {
                            Console.WriteLine("ALuno reprovado");
                            Console.ReadKey();
                        }
                        else if (md >= 7)
                        {
                            Console.WriteLine("Aluno aprovado");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Aluno em recuperação");
                        }
                    }
                    Console.WriteLine("Obrigado por testar nossas funcionalidades.");
                }
                else if (res == 2)
                {
                    Console.Clear();
                }
            }
        }
    }
}
