using Classes;
using Acesso;
using Calculo;
using Diretorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    class TelaUsuario
    {
        public static void Chamar()
        {
            Console.WriteLine("============================= Cadastro de Usuário ============================");

            while (true)
            {
                string mensagem = "Digite uma das opções abaixo: " +
                    "\n   0 - Sair do Cadastro" +
                    "\n   1 - Cadastrar usuário" +
                    "\n   2 - Listar usuários";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if(valor == 0)
                {
                    break;
                }
                else if(valor == 1)
                {
                    var usuario = new Usuário();
                    Console.WriteLine("Digite o nome do User: ");
                    usuario.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o Telefone: ");
                    usuario.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF: ");
                    usuario.CPF = Console.ReadLine();

                    usuario.Gravar();
                }
                else
                {
                    var usuario = new Usuário().Ler();
                    foreach (Usuário c in usuario)
                    {
                        Console.WriteLine("==============");

                        Console.WriteLine("Nome: " + c.Nome);
                        Console.WriteLine("Telefone: " + c.Telefone);
                        Console.WriteLine("CPF: " + c.CPF);

                        Console.WriteLine("============");
                    }
                }
            }
        }
    }
}
