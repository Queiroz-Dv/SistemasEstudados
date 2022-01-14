using System;

namespace Treinojunior
{
    class MenuPrincipal
    {
        public static void Criar()

        {
            while (true)
            {
                Console.Clear();
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
                switch (valor)
                {
                    case 0:
                        MenuAlternativo.Menu();
                        continue;
                    case 1:
                        TesteSequencial.Menu();
                        continue;
                    case 2:
                        PulaNumero.Menu();
                        continue;
                    case 3:
                        TesteContinuo.Menu();
                        continue;
                    case 4:
                        TesteTabuada.Menu();
                        continue;
                    case 5:
                        TesteFatoracao.Menu();
                        continue;
                    case 6:
                        TesteFibo.Menu();
                        continue;
                    case 7:
                        TesteComplexo.Menu();
                        continue;
                    case 8:
                        TesteComplexoSwitch.Menu();
                        continue;
                    case 9:
                        TesteValidacao.Menu();
                        continue;
                    case 10:
                        Console.WriteLine("Tem certeza que deseja sair do sistema?" +
                            "\nDigite 1 para sim e 0 para não");
                        int s = int.Parse(Console.ReadLine());
                        if (s == 1)
                        { break; }
                        else
                        { continue; }
                    default:
                        Console.WriteLine("Opção inválida");
                        continue;
                }
                break;
            }
        }
    }
}


