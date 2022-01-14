using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Fornecedor : Base
    {
        public string CNPJ;
        public Fornecedor(string nome, string telefone, string cpf, string cnpj)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
;            this.CNPJ = cnpj;
        }

        public Fornecedor(){ }

        public override void Gravar()
        {
            
                var dados = this.Ler();
                dados.Add(this);
                //if (File.Exists(diretorioArquivo()))

                StreamWriter r = new StreamWriter(diretorioArquivo());
                r.WriteLine("nome;telefone;cpf;cnpj;");
                foreach (Fornecedor b in dados)
                {
                    var linha = b.Nome + ";" + b.Telefone + ";" + b.CPF + ";" + CNPJ + ";";
                    r.WriteLine(linha);
                }

                r.Close();

            
        }

        public override List<IPessoa> Ler()
        {
            var dados = new List<IPessoa>();
            if (File.Exists(diretorioArquivo()))
            {
                using (StreamReader arquivo = File.OpenText(diretorioArquivo()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var baseArquivo = linha.Split(';');

                        var b = (Fornecedor)Activator.CreateInstance(this.GetType());
                        b.SetNome(baseArquivo[0]);
                        b.SetTelefone(baseArquivo[1]);
                        b.SetCPF(baseArquivo[2]);
                        b.CNPJ = (baseArquivo[3]);
                        dados.Add(b);
                    }
                }
            }
            return dados;
        }
    }
}