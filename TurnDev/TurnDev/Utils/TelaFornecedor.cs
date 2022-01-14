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
    class TelaFornecedor
    {
        public static void Chamar()
        {
            Console.WriteLine("============================= Cadastro de Fornecedor ============================");

            while (true)
            {
                string mensagem = "Digite uma das opções abaixo: " +
                    "\n   0 - Sair do Cadastro" +
                    "\n   1 - Cadastrar Fornecedores" +
                    "\n   2 - Listar Fornecedores";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if(valor == 0)
                {
                    break;
                }
                else if(valor == 1)
                {
                    var fornecedor = new Fornecedor();

                    Console.WriteLine("Digite o nome do Fornenecedor: ");
                    fornecedor.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o CNPJ: ");
                    fornecedor.CNPJ = Console.ReadLine();

                    Console.WriteLine("Digite o Telefone do Fornecedor: ");
                    fornecedor.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do Fornecedor: ");
                    fornecedor.CPF = Console.ReadLine();

                    fornecedor.Gravar();
                }
                else
                {
                    var fornecedores = new Fornecedor().Ler();
                    foreach (Fornecedor c in fornecedores)
                    {
                        Console.WriteLine("==============");

                        Console.WriteLine("Nome: " + c.Nome);
                        Console.Write("CNPJ: " + c.CNPJ);
                        Console.WriteLine("Telefone: " + c.Telefone);
                        Console.WriteLine("CPF: " + c.CPF);

                        Console.WriteLine("============");
                    }
                }
            }
        }
    }
}
