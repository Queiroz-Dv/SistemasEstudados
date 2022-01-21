using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinojunior.ProjectModel;

namespace ProjectPersistence
{
    public class Repository
    {
        private IList<Fornecedor> fornecedores = new List<Fornecedor>();
        private IList<Produto> produtos = new List<Produto>();
        private IList<InputNota> inputNotas = new List<InputNota>();


        //CRUD Fornecedor 
        public Fornecedor InsertFornecedor( Fornecedor fornecedor)
        {
            this.fornecedores.Add(fornecedor);
            return fornecedor;
        }

        public void RemoverFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores.Remove(fornecedor);
        }

        public IList<Fornecedor> GetAllFornecedors()
        {
            return this.fornecedores;
        }

        public Fornecedor UpdateFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores[this.fornecedores.IndexOf(fornecedor)] = fornecedor;
            return fornecedor;
        }
    }
}
