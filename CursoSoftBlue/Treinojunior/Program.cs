using System;

namespace Treinojunior
{
    class Program: MenuPrincipal
    {
        static void Main(string[] args)
        {
            MenuPrincipal obj = new MenuPrincipal();
            PaginaDois paginaDois = new PaginaDois();
            while (true)
            {
                switch (obj.Criar())
                {
                    case 0:
                        paginaDois.Menu();
                        break;
                    case 1:
                        TesteSequencial.Menu();
                        break;
                    case 2:
                        PulaNumero.Menu();
                        break;
                    case 3:
                        TesteContinuo.Menu();
                        break;
                    case 4:
                        TesteTabuada.Menu();
                        break;
                    case 5:
                        TesteFatoracao.Menu();
                        break;
                    case 6:
                        TesteFibo.Menu();
                        break;
                    case 7:
                        TesteComplexo.Menu();
                        break;
                    case 8:
                        TesteComplexoSwitch.Menu();
                        break;
                    case 9:
                        TesteValidacao.Menu();
                        break;
                    case 10:
                        Console.WriteLine("\n");
                        Centralizar("Obrigado por ver meus estudos");
                        Centralizar("Pressione qualquer tecla para fechar a janela");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\n");
                        Centralizar("Opção inválida | Tente novamente!");
                        break;
                }
                Console.Clear();

            }
        }
    }

}








