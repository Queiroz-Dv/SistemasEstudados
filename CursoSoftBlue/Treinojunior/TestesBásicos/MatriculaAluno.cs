using System;
using Treinojunior.Base;

namespace Treinojunior.TestesBásicos
{
    class MatriculaAluno : BasePessoa
    {
        public MatriculaAluno()
        {
            //Tamanho da tela
            Console.SetWindowSize(100, 20);
            //Nome de cima da tela
            Console.Title = "Queiroz Sistemas[v1.0]";
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static int Menu()
        {
            while (true)
            {
                Console.Clear();
                Centralizar("==== Bem Vindo ao Diário de Sistemas ====\n");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Linha();
                Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "  =============================="));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 0. Menu Principal <<         ||"));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 1. Matricular aluno          ||"));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "  ============================== "));
                Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("\n{0}", AlinhaTexto(36, "Digite o que deseja fazer: ", "L"));
                try
                {
                    int valor = int.Parse(Console.ReadLine());
                    switch (valor)
                    {
                        case 0:
                            Centralizar("Obrigado por testar meu sistema. Volte sempre!");
                            Centralizar("Pressione qualquer tecla para voltar ao menu principal");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 1:
                            Console.Clear();
                            string Categoria;
                            BasePessoa aluno = new BasePessoa();

                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Linha();
                            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                            Console.WriteLine("|{0}|", AlinhaTexto(35, "     Digite o nome:"));
                            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                            Console.BackgroundColor = ConsoleColor.Black;
                            aluno.Nome = Console.ReadLine();
                            string nome = aluno.Nome;

                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Linha();
                            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                            Console.WriteLine("|{0}|", AlinhaTexto(35, $" Digite o nome: {nome}                         "));
                            Console.WriteLine("|{0}|", AlinhaTexto(35, $" Digite o ano do seu nascimento:               "));
                            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                            Console.BackgroundColor = ConsoleColor.Black;
                            aluno.AnoNascimento = Console.ReadLine();
                            string anoNascimento = aluno.AnoNascimento;

                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Linha();
                            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                            Console.WriteLine("|{0}|", AlinhaTexto(35, $" Digite o nome: {nome}                                  "));
                            Console.WriteLine("|{0}|", AlinhaTexto(35, $" Digite o ano do seu nascimento: {anoNascimento}        "));
                            Console.WriteLine("|{0}|", AlinhaTexto(35, $" Digite o ano do seu último aniversário:                "));
                            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine($"Digite o ano do seu último aniversário {nome}: ");
                            string anoUltimoAniversario = Console.ReadLine();

                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkGray;
                            Linha();
                            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                            Console.WriteLine("|{0}|", AlinhaTexto(35, $" Digite o nome: {nome}                                         "));
                            Console.WriteLine("|{0}|", AlinhaTexto(35, $" Digite o ano do seu nascimento: {anoNascimento}                "));
                            Console.WriteLine("|{0}|", AlinhaTexto(35, $" Digite o ano do seu último aniversário: {anoUltimoAniversario} "));
                            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                            Console.BackgroundColor = ConsoleColor.Black;

                            Centralizar("Dados obtidos.");
                            Centralizar("Aperte qualquer tecla para analisarmos.");
                            Console.ReadKey();
                            Console.Clear();

                            if (anoNascimento.Trim().Length < 4 || anoUltimoAniversario.Trim().Length < 4)
                            {
                                Centralizar("É preciso informar o ano com 4 digitos");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            if (anoUltimoAniversario != String.Empty &&
                                Convert.ToInt32(anoUltimoAniversario) <=
                                Convert.ToInt32(anoNascimento))
                            {
                                Centralizar("O ano do último aniversário deve" +
                                                  "se superior ao ano de nascimento");

                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            if (nome == String.Empty || anoNascimento == String.Empty || anoUltimoAniversario == String.Empty)
                            {
                                Centralizar("Todos os dados devem ser informados.");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            else
                            {
                               // TimeSpan tsQuantidadeDias = DateTime.Now.Date - Convert.ToDateTime(anoNascimento);
                               // int idade = (tsQuantidadeDias.Days / 365);
                                int idade = Convert.ToInt32(anoUltimoAniversario) - Convert.ToInt32(anoNascimento);
                                if (idade > 17)
                                {
                                    Centralizar(Categoria = $"{nome} esta na categoria Adulto");
                                    Centralizar($"Matrícula de {nome} realizada com sucesso.");
                                    Centralizar("Pressione qualquer tecla para voltar ao menu.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                }
                                else if (idade > 13)
                                {
                                    Centralizar(Categoria = $"{nome} esta na categoria Juvenil B");
                                    Centralizar($"Matrícula de {nome} realizada com sucesso.");
                                    Centralizar("Pressione qualquer tecla para voltar ao menu.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                }
                                else if (idade > 10)
                                {
                                    Centralizar(Categoria = $"{nome} esta na categoria Juvenil A");
                                    Centralizar($"Matrícula de {nome} realizada com sucesso.");
                                    Centralizar("Pressione qualquer tecla para voltar ao menu.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                }
                                else if (idade > 7)
                                {
                                    Centralizar(Categoria = $"{nome} esta na categoria Infatil B");
                                    Centralizar($"Matrícula de {nome} realizada com sucesso.");
                                    Centralizar("Pressione qualquer tecla para voltar ao menu.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                }
                                else if (idade >= 5)
                                {
                                    Centralizar(Categoria = $"{nome} esta na categoria Infatil A");
                                    Centralizar($"Matrícula de {nome} realizada com sucesso.");
                                    Centralizar("Pressione qualquer tecla para voltar ao menu.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Centralizar(Categoria = $"Não existe categoria");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            continue;
                        default:
                            Centralizar("Opção inválida");
                            Console.ReadKey();
                            Console.Clear();
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
        public static int Centralizar(string centre)
        {
            int espacos = 50 + (centre.Length / 2);
            Console.WriteLine(centre.PadLeft(espacos));
            return espacos;
        }

        public static string AlinhaTexto(int EspacosParaAdicionar, string Msg, string Alinhamento = "R")
        {
            if (Alinhamento == "L")
                Msg = Msg.PadLeft(EspacosParaAdicionar + Msg.Length);
            else
            {
                Msg = Msg.PadLeft(EspacosParaAdicionar + Msg.Length);
                Msg = Msg.PadRight((98 - Msg.Length) + Msg.Length);
            }
            return Msg;
        }

        public static void Linha()
        {
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
        }
    }
}
