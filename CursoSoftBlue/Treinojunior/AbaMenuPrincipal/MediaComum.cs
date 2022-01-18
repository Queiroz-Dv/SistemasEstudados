using System;

namespace Treinojunior.TestesMatematicos.ModelosMedia
{
    class MediaComum
    {
        public MediaComum()
        {
            //Tamanho da tela
            Console.SetWindowSize(100, 20);
            //Nome de cima da tela
            Console.Title = "Media Comum";
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Menu()
        {
            while (true)
            {
                Console.Clear();
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
                    break;
                }
                else if (res == 1)
                {
                    ColetaDados(out double n1, out double n2, out double n3);
                    if (n1 == -1 || n2 == -1 || n3 == -1)
                    {
                        Console.WriteLine("Números inválidos. Pressione qualquer tecla");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        int md = Convert.ToInt32((n1 + n2 + n3) / 3);
                        if (md < 5)
                        {
                            Console.WriteLine("ALuno reprovado");
                            Console.WriteLine("A média do aluno foi: " + md);
                            Console.ReadKey();
                            continue;
                        }
                        else if (md >= 7)
                        {
                            Console.WriteLine("Aluno aprovado");
                            Console.WriteLine("A média do aluno foi: " + md);
                            Console.ReadKey();
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Aluno em recuperação");
                            Console.WriteLine("A média do aluno foi: " + md);
                            Console.ReadKey();
                            continue;
                        }
                    }
                }
                else if (res == 2)
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                    Console.ReadKey();
                }
            }
        }

        private static void ColetaDados(out double n1, out double n2, out double n3)
        {
            Console.WriteLine("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            n3 = double.Parse(Console.ReadLine());
        }
    }
}
