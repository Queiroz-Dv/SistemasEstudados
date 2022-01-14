using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinojunior.Banco;

namespace Treinojunior.BancoMatematico.BaseOperacional
{
    public class Cliente : BaseOP
    {
        public Cliente(string nome, string sobrenome, string datanasc,
            string telefone, string cpf, string endereco)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.DataNasc = datanasc;
            this.Telefone = telefone;
            this.CPF = cpf;
            this.Endereco = endereco;
        }
        public Cliente() { }
    }
}
