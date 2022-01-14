using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diretorio
{
    class Arquivo
    {
        private static string caminhoArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoArquivos"];
        }
        public static void Ler (int numeroArquivo)
        {
            string caminho = caminhoArquivo() + "arq" + numeroArquivo + ".txt";
            if (File.Exists(caminho))
            {
                using (StreamReader arquivo = File.OpenText(caminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            Console.WriteLine("==============");
            string caminho2 = caminhoArquivo() + (numeroArquivo + 1) + ".txt";

            if (File.Exists(caminho2))
            {
                Arquivo.Ler(numeroArquivo + 1);
            }
        }
    }
}
