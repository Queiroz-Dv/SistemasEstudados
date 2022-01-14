using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    class Media
    {
        public static void Aluno()
        {
            Console.WriteLine("Digite o nome do aluno");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno " + nome);

            List<int> notas = new List<int>();
            var totalNotas = 0;
            var qtdNotas = 1;
            for (int i = 0; i <= qtdNotas; i++)
            {
                Console.WriteLine("Digite a nota número " + i);
                int nota = int.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);

            }
            int media = totalNotas / notas.Count;
            Console.WriteLine("A média do aluno " + nome + " é " + media);

            foreach (int nota in notas)
            {
                Console.WriteLine("Notas: " + nota + "\n");
            }
        }
    }
}
