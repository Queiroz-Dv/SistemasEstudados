using System;
using Treinojunior.Banco;
using Treinojunior.Banco.Operacoes;

namespace Treinojunior.POO
{
    class EntradaBanco : BaseOP
    {
        public static void Entre()
        {
            while (true)
            {


                string menu = "Bm vinddo ao nosso Banco de Matemáticos!\n" +
                    "\n         Digite o que deseja fazer" +
                    "\n         1 - Cadastrar" +
                    "\n         2 - Alterar dados" +
                    "\n         3 - Depositar" +
                    "\n         4 - Sacar" +
                    "\n         5 - Transferir" +
                    "\n         6 - Apagar conta";
                Console.WriteLine(menu);
                int res = int.Parse(Console.ReadLine());

                if (res == 1)
                {
                    Cadastre.Cadastro();
                }
                else if (res == 2)
                {

                }
                else if (res == 3)
                {

                }
                else if (res == 4)
                {

                }
                else if (res == 5)
                {

                }
                else if (res == 6)
                {

                }
                else
                {
                    //MenuPrincipal entrar = ();
                }
            }
        }
    }
}
