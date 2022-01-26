using System.Collections.Generic;
using Treinojunior.ProjectModel;

namespace ProjectPersistence
{
    public class Repository
    {
        private IList<Fornecedor> fornecedores = new List<Fornecedor>();
        private IList<Produto> produtos = new List<Produto>();
        private IList<NotaEntrada> inputNotas = new List<NotaEntrada>();


        //CRUD Fornecedor 
        public Fornecedor InsertFornecedor(Fornecedor fornecedor)
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

        public NotaEntrada GetNotaByID(long? ID)
        {
            var notaEntrada = this.inputNotas[this.inputNotas.IndexOf(new NotaEntrada() { ID = ID })];
            return notaEntrada;
        }

        //CRUD Produto
        public Produto InsertProduto(Produto produto)
        {
            this.produtos.Add(produto);
            return produto;
        }

        public void RemoverProduto(Produto produto)
        {
            this.produtos.Remove(produto);
        }

        public IList<Produto> GetAllProdutos()
        {
            return this.produtos;
        }

        public Produto UpdateProduto(Produto produto)
        {
            this.produtos[this.produtos.IndexOf(produto)] = produto;
            return produto;
        }

        //CRUD Notas
        public NotaEntrada InsertNota(NotaEntrada nota)
        {
            this.inputNotas.Add(nota);
            return nota;
        }

        public void RemoverNotas(NotaEntrada nota)
        {
            this.inputNotas.Remove(nota);
        }

        public IList<NotaEntrada> GetAllNotas()
        {
            return this.inputNotas;
        }

        public NotaEntrada UpdateNota(NotaEntrada nota)
        {
            this.inputNotas[this.inputNotas.IndexOf(nota)] = nota;
            return nota;
        }
    }
}
