using ConsumoEnergiaCondominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinojunior.ProjetosGrandes
{
    class ConsumoEnergia
    {
        public ConsumoEnergia()
        {
            //Tamanho da tela
            Console.SetWindowSize(100, 20);
            //Nome de cima da tela
            Console.Title = "Sistema Consumo de Energia";
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static int Menu()
        {
            while (true)
            {
                
                Console.Clear();
                Centralizar("==== Bem Vindo ao Diário de Sistemas ====\n");
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Linha();
                Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 0. Voltar  <<      "));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 1. Registrar       "));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 2. Listar          "));
                Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 3. Processar dados "));
                Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                Linha();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("\n{0}", AlinhaTexto(36, "Digite o que deseja fazer: ", "L"));
                int valor = int.Parse(Console.ReadLine());
                if (valor == 0)
                {
                    Centralizar("Obrigado por testar meu sistema. Volte sempre!");
                    Centralizar("Pressione qualquer tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                else if (valor == 1)
                {
                    //View
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Linha();
                    Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                    Console.WriteLine("|{0}|", AlinhaTexto(35, "Nº Casa:  "));
                    Console.WriteLine("|{0}|", AlinhaTexto(35, "Consumo:  "));
                    Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                    Linha();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Centralizar(":");
                    int getCasa = int.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Linha();
                    Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                    Console.WriteLine("|{0}|", AlinhaTexto(35, $"Nº Casa:{getCasa}  "));
                    Console.WriteLine("|{0}|", AlinhaTexto(35, "Consumo:  "));
                    Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                    Linha();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Centralizar("Digite o consumo: ");
                    int getConsumo = int.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Linha();
                    Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                    Console.WriteLine("|{0}|", AlinhaTexto(35, $"Nº Casa: {getCasa}  "));
                    Console.WriteLine("|{0}|", AlinhaTexto(35, $"Consumo: {getConsumo} "));
                    Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
                    Linha();
                    Console.BackgroundColor = ConsoleColor.Black;

                    Centralizar("");



                }
                else if (valor == 3)
                {

                }
                return valor;
            }
        }
        private void RegistrarConsumo(string casa, double consumo)
        {
            IList<BaseLeitura> leituras = new BindingList<BaseLeitura>();
            BaseLeitura leitura = new BaseLeitura(casa, consumo);
            if (leituras.Contains(leitura))
            {
                Centralizar("Esta casa já foi registrada");
            }
            else
            {
                leituras.Add(leitura);
            }
        }
        private void ProcessarLeituras(string casa, double consumo, int total, double desconto)
        {
            var dados = new List<BaseLeitura>();
            dados.Add(new BaseLeitura(, 0))
        }
        public static string AlinhaTexto(int EspacosParaAdicionar, string Msg, string Alinhamento = "R")
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
        public static void Linha()
        {
            Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
        }
        public static int Centralizar(string centre)
        {
            int espacos = 50 + (centre.Length / 2);
            Console.WriteLine(centre.PadLeft(espacos));
            return espacos;
        }
    }

}
