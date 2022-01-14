using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    class Tabuada
    {
        public const int SAIR = 0;
        public const int MULTIPLICACAO = 1;
        public const int ADICAO = 2;
        public const int SUBTRACAO = 3;
        public const int DIVISAO = 4;
        public const int MEDIA = 5;


        public static void Calcular(int Calc)
        {
            var valor = Calc;
            if (Calc == 0)
            {
                Console.WriteLine("Fechando");
            }


            if (valor == MULTIPLICACAO)
            {
                Console.WriteLine("====== Cálculo da Tabuada de Multiplicação de " + Calc + " abaixo" + "======");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(Calc + " x " + i + " = " + (Calc * i));
                }
                Console.WriteLine("======||||||======||||||======");
            }
            else if (valor == ADICAO)
            {
                Console.WriteLine("====== Cálculo da Tabuada de Adição de " + Calc + " abaixo" + "======");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(Calc + " x " + i + " = " + (Calc + i));
                }
                Console.WriteLine("======||||||======||||||======");
            }
            else if (valor == SUBTRACAO)
            {
                Console.WriteLine("====== Cálculo da Tabuada de Subtração de " + Calc + " abaixo" + "======");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(Calc + " x " + i + " = " + (Calc - i));
                }
                Console.WriteLine("======||||||======||||||======");
            }
            else if (valor == DIVISAO)
            {
                Console.WriteLine("====== Cálculo da Tabuada de Divisão de " + Calc + " abaixo" + "======");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(Calc + " x " + i + " = " + (Calc / i));
                }
                Console.WriteLine("======||||||======||||||======");
            }
            else if (valor == MEDIA)
            {
                List<int> numeros = new List<int>();
                Console.WriteLine("====== Cálculo da Média======");
                int media = 0;
                var somatorio = 0;

                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine("Digite o " + i + "º numero para a média: ");
                    numeros.Add(int.Parse(Console.ReadLine()));
                }

                //Console.WriteLine("Digite o valor da média");
                //media = int.Parse(Console.ReadLine());
                media = 3;

                foreach (var Soma in numeros)
                {
                    somatorio = somatorio + Soma;
                    //somatorio =+ Soma mesma coisa de cima
                }

                var resultado = somatorio / media;

                Console.WriteLine("A media do aluno é" + resultado);

                //for (int i = 0; i <= 10; i++)
                //{
                //    qtdNumero += n;
                //    int a = (n + i);
                //}

                    

                //if (n < 10)
                //{
                //    Console.WriteLine("Você só poderá calcular com 10 números.");
                //}


                Console.WriteLine("======||||||======||||||======");
            }

            /*Console.WriteLine("====== Cálculo da Tabuada de multiplicação de " + Calc + " abaixo" + "======");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Calc + " x " + i + " = " + (Calc * i));
            }
            Console.WriteLine("======||||||======||||||======");

            Console.WriteLine("====== Cálculo da Tabuada de multiplicação de " + Calc + " abaixo" + "======");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Calc + " x " + i + " = " + (Calc * i));
            }
            Console.WriteLine("======||||||======||||||======");*/
        }
    }
}

