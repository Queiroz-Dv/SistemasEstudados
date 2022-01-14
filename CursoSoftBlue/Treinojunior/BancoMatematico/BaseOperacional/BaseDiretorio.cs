using System;
using System.IO;
using System.Configuration;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diretorio
{
    class BaseArquivos
    {
        private static string arquivoPath()
        {
            return ConfigurationManager.AppSettings["PathArquivos"];
        }
        public static void Leia( int idArquivo)
        {
            string path = arquivoPath() + "arc" + idArquivo + ".txt";
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
            string path2 = arquivoPath() + (idArquivo + 1) + ".txt";

            if (File.Exists(path2))
            {
                Leia(idArquivo + 1);
            }
        }
    }
}
