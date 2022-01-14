using Calculo;
using Diretorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Acesso
{
    class Menu
    {

        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int CADASTRAR_CLIENTE = 4;
        public const int CADASTRAR_USUARIO = 5;
        public const int CADASTRAR_FORNECEDOR = 6;
        public static void Criar()
        {
            while (true)
            {
                string mensagem = "Olá usuário, bem vindo!\n" +
                    "\n\n" +
                    "\n           Digite uma das opções abaixo:" +
                    "\n           0 - Sair do Programa" +
                    "\n           1 - Ler Aquivos" +
                    "\n           2 - Tabuada" +
                    "\n           3 - Cálculo Aluno" +
                    "\n           4 - Cadastrar Cliente" +
                    "\n           5 - Cadastrar Usuário" +
                    "\n           6 - Cadastrar Fornecedores";

                
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());




                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Arquivo.Ler(1);
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("============= Tabuada ==============");
                    Console.WriteLine("Digite uma das opções da tabuada:");
                    string men = "\n\n" +
                           "\n           0 - Sair" +
                           "\n           1 - Multiplicação" +
                           "\n           2 - Adição" +
                           "\n           3 - Subtração" +
                           "\n           4 - Divisão" +
                           "\n           5 - Média";
                    Console.WriteLine(men);
                    int Calc = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(Calc);
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Media.Aluno();

                }
                else if (valor == CADASTRAR_CLIENTE)
                {
                    TelaCliente.Chamar();
                }
                else if (valor == CADASTRAR_USUARIO)
                {
                    TelaUsuario.Chamar();
                }
                else if ( valor == CADASTRAR_FORNECEDOR)
                {
                    TelaFornecedor.Chamar();
                }
                else
                {
                    Console.WriteLine("Opção Inválida");
                }
            }
        }
    }
}

