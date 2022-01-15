using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Treinojunior.BancoMatematico.BaseOperacional;

namespace Treinojunior.Banco
{
    public abstract class BaseOP : IPessoa
    {
        public BaseOP(int id, string nome, string sobrenome, string datanasc,
            string telefone, string cpf, string endereco){
            this.ID = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.DataNasc = datanasc;
            this.Telefone = telefone;
            this.CPF = cpf;
            this.Endereco = endereco;
        }
        public BaseOP() { }
        //Pega os dados 
        public int ID;
        public string Nome;
        public string Sobrenome;
        public string DataNasc;
        public string Telefone;
        public string CPF;
        public string Endereco;

        //Implementa os fields
        public void SetID(int id)
        {
            this.ID = id;
        }
        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public void SetSobrenome(string sobrenome)
        {
            this.Sobrenome = sobrenome;
        }

        public void SetDataNasc(string datanasc)
        {
            this.DataNasc = datanasc;
        }

        public void SetTelefone(string telefone)
        {
            this.Telefone = telefone;
        }

        public void SetCPF(string cpf)
        {
            this.CPF = cpf;
        }

        public void SetEndereco(string endereco)
        {
            this.Endereco = endereco;
        }

        public virtual void Gravar()
        {
            var dados = this.Leia();
            dados.Add(this);

            StreamWriter escreva = new StreamWriter(arquivoDiretorio());
            escreva.WriteLine("nome;sobrenome;datnasc;telefone;cpf;endereço");
            foreach (BaseOP b in dados)
            {
                var linha = b.Nome + ";" + b.Sobrenome + ";" + b.DataNasc +
                    ";" + b.Telefone + ";" + b.CPF + ";" + b.Endereco + ";";
                escreva.WriteLine(linha);
            }
            escreva.Close();
        }
        public virtual List<IPessoa> Leia()
        {
            var dados = new List<IPessoa>();
            if (File.Exists(arquivoDiretorio()))
            {
                using (StreamReader arquivo = File.OpenText(arquivoDiretorio()))
                {
                    string linha;
                    int a = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        a++;
                        if (a == 1)
                        {
                            continue;
                        }
                        var arquivoBase = linha.Split(';');

                        var b = (IPessoa)Activator.CreateInstance(this.GetType());
                        b.SetNome(arquivoBase[0]);
                        b.SetSobrenome(arquivoBase[1]);
                        b.SetDataNasc(arquivoBase[2]);
                        b.SetTelefone(arquivoBase[3]);
                        b.SetCPF(arquivoBase[4]);
                        b.SetEndereco(arquivoBase[5]);
                        dados.Add(b);
                    }
                }
            }
            return dados;
        }

        public string arquivoDiretorio()
        {
            var dir = ConfigurationManager.AppSettings["CaminhoArquivos"] + this.GetType().Name + ".txt";
            return ConfigurationManager.AppSettings["CaminhoArquivos"] + this.GetType().Name + ".txt";
        }
    }
}
