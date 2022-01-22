using ProjectPersistence;
using System.Collections.Generic;
using Treinojunior.ProjectModel;

namespace ProjectController
{
    public class FornecedorController
    {
        private Repository repository = new Repository();

        public Fornecedor Insert(Fornecedor fornecedor)
        {
            return this.repository.InsertFornecedor(fornecedor);
        }

        public void Remove(Fornecedor fornecedor)
        {
            this.repository.RemoverFornecedor(fornecedor);
        }

        public IList<Fornecedor> GetAll()
        {
            return this.repository.GetAllFornecedors();
        }

        public Fornecedor Update(Fornecedor fornecedor)
        {
            return this.repository.UpdateFornecedor(fornecedor);
        }
    }
}
