using System;
using Treinojunior.POO;

namespace Treinojunior
{
    class MenuPrincipal
    {
        public const int TROCA_MENU = 0;
        public const int TESTE_CONTADOR_SEQUENCIAL = 1;
        public const int TESTE_PULAR_NUMERO = 2;
        public const int TESTE_CONTINUO = 3;
        public const int TESTE_TABUADA = 4;
        public const int TESTE_FATORIAL = 5;
        public const int TESTE_FIBONACCI = 6;
        public const int TESTE_IF_COMPLEXO = 7;
        public const int TESTE_SWITCH_COMPLEXO = 8;
        public const int TESTE_VALIDADE = 9;
        public const int FECHAR = 10;

        public static void Criar()

        {
            while (true)
            {
                
                string mensagem = "Olá usuário, bem vindo ao sistema de testes matemáticos!\n" +
                    "\n\n" +
                    "\n           Digite uma das opções abaixo:" +
                    "\n           0 - Outras funções" +
                    "\n           1 - Teste Contador Sequencial" +
                    "\n           2 - Teste Pular Números" +
                    "\n           3 - Teste Contínuo" +
                    "\n           4 - Teste Tabuada" +
                    "\n           5 - Teste Fatorial" +
                    "\n           6 - Teste Fibonacci" +
                    "\n           7 - Teste If Complexo" +
                    "\n           8 - Teste Switch Complexo" +
                    "\n           9 - Teste Validade" +
                    "\n           10 - Fechar programa";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());
                
                if (TROCA_MENU== valor)
                {
                    Console.Clear();
                    MenuAlternativo.MontarMenu();
                }
                else if (valor == TESTE_CONTADOR_SEQUENCIAL)
                {
                    TesteSequencial.Menu();
                }
                else if (valor == TESTE_PULAR_NUMERO)
                {
                    PulaNumero.Menu();
                }
                else if (valor == TESTE_CONTINUO)
                {
                    TesteContinuo.Menu();
                }
                else if (valor == TESTE_TABUADA)
                {
                    TesteTabuada.Menu();
                }
                else if (valor == TESTE_FATORIAL)
                {
                    TesteFatoracao.Menu();
                }
                else if (valor == TESTE_FIBONACCI)
                {
                    TesteFibo.Menu();
                }
                else if (valor == TESTE_IF_COMPLEXO)
                {
                    TesteComplexo.Menu();

                }
                else if (valor == TESTE_SWITCH_COMPLEXO)
                {
                    TesteComplexoSwitch.ComplexoSwitch();
                }
                else if (valor == TESTE_VALIDADE)
                {
                    TesteValidacao.Valida();
                    
                }
                else if(valor == FECHAR)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção Inválida");
                }
            }
        }
    }
}


