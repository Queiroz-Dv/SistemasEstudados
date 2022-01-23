using System;
using System.Collections.Generic;
using Treinojunior.ProjectModel;

namespace ProjectPersistence
{
    public class Repository
    {
        private IList<Fornecedor> fornecedores = new List<Fornecedor>();
        private IList<Produto> produtos = new List<Produto>();
        private IList<InputNota> inputNotas = new List<InputNota>();


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

        public InputNota GetNotaByID(Guid iD)
        {
            var notaEntrada = this.inputNotas[this.inputNotas.IndexOf(new InputNota() { ID = iD })];
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
        public InputNota InsertNota(InputNota nota)
        {
            this.inputNotas.Add(nota);
            return nota;
        }

        public void RemoverNotas(InputNota nota)
        {
            this.inputNotas.Remove(nota);
        }

        public IList<InputNota> GetAllNotas()
        {
            return this.inputNotas;
        }

        public InputNota UpdateNota(InputNota nota)
        {
            this.inputNotas[this.inputNotas.IndexOf(nota)] = nota;
            return nota;
        }
    }
}
