using System;
using Treinojunior.Base;

namespace Treinojunior.TestesBásicos
{
    class MatriculaAluno : BasePessoa
    {
        public static void Menu()
        {
            while (true)
            {
                Console.Clear();
                string corpoMenu = "Olá usuário, bem vindo ao Sistema de Matrilar Alunos\n" +
                                   "\n\n" +
                                   "\n           Digite o que deseja fazer abaixo:" +
                                   "\n           0 - Voltar" +
                                   "\n           1 - Matricular";
                Console.WriteLine(corpoMenu);
                int res = int.Parse(Console.ReadLine());
                if (res == 0)
                {
                    Console.WriteLine("Obrigado por testar nosso sistema." +
                                      "Volte sempre!");
                    Console.ReadKey();
                    break;
                }
                else if (res == 1)
                {

                    Console.Clear();
                    //string Categoria;
                    BasePessoa aluno = new BasePessoa();

                    Console.WriteLine("Digite o nome: ");
                    aluno.Nome = Console.ReadLine();
                    string nome = aluno.Nome;

                    Console.WriteLine($"Digite o ano de nascimento {nome}: ");
                    aluno.AnoNascimento = Console.ReadLine();
                    string anoNascimento = aluno.AnoNascimento;

                    Console.WriteLine($"Digite o ano do seu último aniversário {nome}: ");
                    string anoUltimoAniversario = Console.ReadLine();

                    if (anoNascimento.Trim().Length < 4 || anoUltimoAniversario.Trim().Length < 4)
                    {
                        Console.WriteLine("É preciso informar o ano com 4 digitos");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    if (anoUltimoAniversario != String.Empty &&
                        Convert.ToInt32(anoUltimoAniversario) <=
                        Convert.ToInt32(anoNascimento))
                    {
                        Console.WriteLine("O ano do último aniversãrio deve" +
                                          "se superior ao ano de nascimento");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                }
            }
        }
    }
}
