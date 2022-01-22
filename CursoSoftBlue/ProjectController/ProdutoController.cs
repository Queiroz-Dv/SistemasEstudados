using ProjectPersistence;
using System.Collections.Generic;
using Treinojunior.ProjectModel;

namespace ProjectController
{
    public class ProdutoController
    {
        private Repository repository = new Repository();
        
        public Produto Insert(Produto produto)
        {
            return this.repository.InsertProduto(produto);
        }
        
        public void Remove(Produto produto)
        {
            this.repository.RemoverProduto(produto);
        }

        public IList<Produto> GetAll()
        {
            return this.repository.GetAllProdutos();
        }
    }
}
