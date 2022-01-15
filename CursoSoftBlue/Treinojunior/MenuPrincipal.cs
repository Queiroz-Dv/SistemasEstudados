using System;

namespace Treinojunior
{
    class MenuPrincipal
    {
        public MenuPrincipal()
        {
            //Tamanho da tela
            Console.SetWindowSize(100, 20);
            //Nome de cima da tela
            Console.Title = "Queiroz Sistemas[v1.0]";
            Console.ForegroundColor = ConsoleColor.White;
        }
        public virtual int Criar()
        {
            Console.Clear();
            Centralizar("==== Bem Vindo ao Diário de Sistemas ====\n");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Linha();
            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
            Console.WriteLine("|{0}|", AlinhaTexto(35, "  =============================="));
            Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 0. Próxima página >>         ||"));
            Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 1. Teste Contador Sequencial ||"));
            Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 2. Teste Pular Números       ||"));
            Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 3. Teste Contínuo            ||"));
            Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 4. Teste Tabuada             ||"));
            Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 5. Teste Fatorial            ||"));
            Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 6. Teste Fibonacci           ||"));
            Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 7. Teste If Complexo         ||"));
            Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 8. Teste Switch Complexo     ||"));
            Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 9. Teste Validade            ||"));
            Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 10. Fechar diário            ||"));
            Console.WriteLine("|{0}|", AlinhaTexto(35, "  ============================== "));
            Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n{0}", AlinhaTexto(36, "Escolha uma das opções de estudo : ", "L"));
            try
            {
                return (int.Parse(Console.ReadLine()));
            }
            catch (FormatException)
            {
                return 0;
            }
        }
        //Configurações gráficas
        public string AlinhaTexto(int EspacosParaAdicionar, string Msg, string Alinhamento = "R")
        {
            if (Alinhamento == "L")
                Msg = Msg.PadLeft(EspacosParaAdicionar + Msg.Length);
            else
            {
                Msg = Msg.PadLeft(EspacosParaAdicionar + Msg.Length);
                Msg = Msg.PadRight((98 - Msg.Length) + Msg.Length);
            }
            return Msg;
        }
        public void Linha()
        {
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
        }
        public int Centralizar(string centre)
        {
            int espacos = 50 + (centre.Length / 2);
            Console.WriteLine(centre.PadLeft(espacos));
            return espacos;
        }
    }
}


