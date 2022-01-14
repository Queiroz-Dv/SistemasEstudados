using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Classes
{
    public abstract class Base : IPessoa
    {
        public Base(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }
        public Base() { }

        public string Nome;
        public string Telefone;
        public string CPF;

        public void SetNome(string nome) { this.Nome = nome; }
        public void SetTelefone(string telefone) { this.Telefone = telefone; }
        public void SetCPF(string cpf) { this.CPF = cpf; }

        public virtual void Gravar()
        {
            var dados = this.Ler();
            dados.Add(this);
            //if (File.Exists(diretorioArquivo()))
            
                StreamWriter r = new StreamWriter(diretorioArquivo());
                r.WriteLine("nome;telefone;cpf;");
                foreach (Base b in dados)
                {
                    var linha = b.Nome + ";" + b.Telefone + ";" + b.CPF + ";";
                    r.WriteLine(linha);
                }

                r.Close();
            
        }

            public virtual List<IPessoa> Ler()
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

                            var b = (IPessoa)Activator.CreateInstance(this.GetType());
                            b.SetNome(baseArquivo[0]);
                            b.SetTelefone(baseArquivo[1]);
                            b.SetCPF(baseArquivo[2]);
                            dados.Add(b);
                        }
                    }
                }
                return dados;
            }

        public string diretorioArquivo()
        {
            var teste =  ConfigurationManager.AppSettings["CaminhoArquivos"] + this.GetType().Name + ".txt";
            return ConfigurationManager.AppSettings["CaminhoArquivos"] + this.GetType().Name + ".txt";
        }
    }
}
