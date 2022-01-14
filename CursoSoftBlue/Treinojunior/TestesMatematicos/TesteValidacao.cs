using System;

namespace Treinojunior
{
    class TesteValidacao
    {
        public static void Valida()
        {


            Console.WriteLine("Seja bem-vindo ao teste de validade");

            Console.WriteLine("Digite o dia: ");
            int dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o mês: ");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Ano: ");
            int ano = int.Parse(Console.ReadLine());

            if (ano < 1900 || ano > 2999)
            {
                Console.WriteLine("Ano digitado é inválido.");
            }

            if (mes < 1 || mes > 12)
            {
                Console.WriteLine("Mês inválido");
            }

            if ((dia <= 31) && (mes <= 12))
            {
                if (((dia > 28) && (mes == 2))
                    || ((dia == 31) && ((mes == 4) || (mes == 6) || (mes == 9) || (mes == 11))))
                {
                    Console.WriteLine("Data inválida");
                }
                else
                {
                    Console.WriteLine("Data válida");
                }
            }

        }
    }
}
