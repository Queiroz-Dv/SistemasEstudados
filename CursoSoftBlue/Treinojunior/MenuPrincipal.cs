using System;

namespace Treinojunior
{
    class MenuPrincipal
    {

        public int Criar()
        {
            //Tamanho da tela
            Console.SetWindowSize(100, 20);
            //Nome de cima da tela
            Console.Title = "Queiroz Sistemas[v1.0]";
            Console.ForegroundColor = ConsoleColor.White;
            while (true)
            {
                Console.Clear();
                Centralizar("==== Diário de Sistemas ====\n");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                string mensagem = "Olá usuário, bem vindo ao Diário de Sistemas!\n" +
                    "\n\n" +
                    "\n           Digite uma das opções abaixo:" +
                    "\n           0 - Próxima página" +
                    "\n           1 - Teste Contador Sequencial" +
                    "\n           2 - Teste Pular Números" +
                    "\n           3 - Teste Contínuo" +
                    "\n           4 - Teste Tabuada" +
                    "\n           5 - Teste Fatorial" +
                    "\n           6 - Teste Fibonacci" +
                    "\n           7 - Teste If Complexo" +
                    "\n           8 - Teste Switch Complexo" +
                    "\n           9 - Teste Validade" +
                    "\n          10 - Fechar progarama";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());
                return valor;
            }
        }
        //Método de cebtralização
        public int Centralizar(string centre) 
        {
            int espacos = 50 + (centre.Length / 2);
            Console.WriteLine(centre.PadLeft(espacos));
            return espacos;
        }
    }
}


