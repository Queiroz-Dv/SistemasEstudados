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
    class TelaCliente
    {
        public static void Chamar()
        {
            Console.WriteLine("============================= Cadastro de Cliente ============================");

            while (true)
            {
                string mensagem = "Digite uma das opções abaixo: " +
                    "\n   0 - Sair do Cadastro" +
                    "\n   1 - Cadastrar clientes" +
                    "\n   2 - Listar Clientes";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if(valor == 0)
                {
                    break;
                }
                else if(valor == 1)
                {
                    var cliente = new Cliente();
                    Console.WriteLine("Digite o nome do Cliente: ");
                    cliente.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o Telefone do Cliente: ");
                    cliente.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do Cliente: ");
                    cliente.CPF = Console.ReadLine();

                    cliente.Gravar();
                }
                else
                {
                    var clientes = new Cliente().Ler();
                    foreach (Base c in clientes)
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
