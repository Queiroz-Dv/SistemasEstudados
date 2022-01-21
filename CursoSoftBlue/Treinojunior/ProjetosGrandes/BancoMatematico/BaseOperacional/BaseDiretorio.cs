using System;
using System.Configuration;
using System.IO;

namespace Diretorio
{
    class BaseArquivos
    {
        private static string ArquivoPath()
        {
            return ConfigurationManager.AppSettings["PathArquivos"];
        }
        public static void Leia( int idArquivo)
        {
            string path = ArquivoPath() + "arc" + idArquivo + ".txt";
            if (File.Exists(path))
            {
                using (StreamReader arquivo = File.OpenText(path))
                {
                    string linha;
                    while ((linha=arquivo.ReadLine())!=null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            Console.WriteLine("+++++++++++++++++");
            string path2 = ArquivoPath() + (idArquivo + 1) + ".txt";

            if (File.Exists(path2))
            {
                Leia(idArquivo + 1);
            }
        }
    }
}
