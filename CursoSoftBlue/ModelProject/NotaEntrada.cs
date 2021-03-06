using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinojunior.ProjectModel
{
    public class NotaEntrada
    {
        public long? ID { get; set; }
        public string Numero { get; set; }
        public Fornecedor FornecedorNota { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataEntrada { get; set; }
        public IList<ProdutoNotaEntrada> Produtos { get; set; }

        public NotaEntrada()
        {
            this.ID = null;
            this.Produtos = new List<ProdutoNotaEntrada>();
        }

        public void GravarProduto(ProdutoNotaEntrada inputProduto)
        {
            if (this.Produtos.Contains(inputProduto))
            {
                this.Produtos.Remove(inputProduto);
            }
            this.Produtos.Add(inputProduto);
        }

        public void RemoverProduto(ProdutoNotaEntrada produto)
        {
            this.Produtos.Remove(produto);
        }

        public void RemoverTodos()
        {
            this.Produtos.Clear();
        }
    }
}
