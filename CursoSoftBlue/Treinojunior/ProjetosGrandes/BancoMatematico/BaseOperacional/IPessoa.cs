using System;

namespace Treinojunior.BancoMatematico.BaseOperacional
{
    public interface IPessoa
    {
        void SetID(int id);
        void SetNome(string nome);
        void SetSobrenome(string sobrenome);
        void SetDataNasc(string datanasc);
        void SetTelefone(string telefone);
        void SetCPF(string cpf);
        void SetEndereco(string endereco);
        void Gravar();

    }
}
