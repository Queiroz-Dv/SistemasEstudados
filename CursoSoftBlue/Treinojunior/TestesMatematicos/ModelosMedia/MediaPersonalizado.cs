using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinojunior.TestesMatematicos.ModelosMedia
{
    class MediaPersonalizado
    {
        public const int VOLTAR = 0;
        public const int TESTAR = 1;
        public const int LIMPAR = 2;
        public static void Executar()
        {
            while (true)
            {
                string corpoMenu = "Olá usuário, bem vindo ao sistema de Média Personalizado \n" +
                    "\n\n" +
                    "\n           Digite o que deseja fazer abaixo:" +
                    "\n           0 - Voltar" +
                    "\n           1 - Teste Personalizado" +
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
                    Console.WriteLine("Digite a quantidade de alunos: ");
                    int qtd_alunos = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a quantidade de materias: ");
                    int qtd_materiais = int.Parse(Console.ReadLine());

                    //A quantidade de materias não pode ser superior a de alunos
                    if (qtd_alunos<qtd_materiais)
                    {
                        Console.WriteLine("Há muitas materias para poucos alunos" +
                            "\n            Digite os dados novamente");
                        Console.ReadKey();
                    }
                    else
                    {
                        for (int i = 0; qtd_alunos > qtd_materiais ; i++)
                        {
                            md = (qtd_materiais*qtd_alunos) / qtd_materiais;
                            Console.WriteLine("A média de cada aluno foi: " + md);
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
