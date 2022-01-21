using System.Collections.Generic;
using System.ComponentModel;

namespace FolhadePagamento
{
    public class ReposFuncionario
    {
        private IList<Funcionario> funcionarios = new BindingList<Funcionario>();

        public void Insert(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
        }

        public IList<Funcionario> GetAll()
        {
            return this.funcionarios;
        }
    }
}
