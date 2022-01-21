using System;
using Treinojunior.BancoMatematico.BaseOperacional;

namespace Treinojunior.Banco.Operacoes
{
    class Cadastre
    {
        public static void Cadastro()
        {
            Console.WriteLine("======= BEM VINDO AO CADASTRO MATEMÁTICO ======");
            while (true)
            {
                string mensagem = "Digite o que deseja fazer: " +
                    "\n   0 - Sair do Cadastro" +
                    "\n   1 - Cadastrar" +
                    "\n   2 - Listar";

                Console.WriteLine(mensagem);
                int res = int.Parse(Console.ReadLine());

                //Pra sair do loop e chamar a outra tela
                if (res == 0)
                {
                    break;
                }
                //Senão continua o processo
                else if (res == 1)
                {
                    var matematico = new Cliente();
                    Console.WriteLine("Digite o nome: ");
                    matematico.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o sobrenome: ");
                    matematico.Sobrenome = Console.ReadLine();

                    Console.WriteLine("Digite a data de nascimento: ");
                    matematico.DataNasc = Console.ReadLine();

                    Console.WriteLine("Digite o telefone: ");
                    matematico.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF");
                    matematico.CPF = Console.ReadLine();

                    Console.WriteLine("Digite o endereco: ");
                    matematico.Endereco = Console.ReadLine();

                    matematico.Gravar();
                }
                else
                {
                    var matematicos = new Cliente().Leia();
                    foreach (BaseOP d in matematicos)
                    {
                        Console.WriteLine("======================");

                        Console.WriteLine("ID:" + d.ID);
                        Console.WriteLine("Nome: " + d.Nome);
                        Console.WriteLine("Sobrenome: " + d.Sobrenome);
                        Console.WriteLine("Data de Nascimento: " + d.DataNasc);
                        Console.WriteLine("Telefone " + d.Telefone);
                        Console.WriteLine("CPF: " + d.CPF);
                        Console.WriteLine("Endereço: " + d.Endereco);
                    }
                }
            }
        }
    }
}
