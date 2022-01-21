using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinojunior.ProjectModel
{
    class InputNota
    {
        public Guid ID { get; set; }
        public string Numero { get; set; }
        public Fornecedor FornecedorNota { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataEntrada { get; set; }
        public IList<InputProdutoNota> Produtos { get; set; }

        public InputNota()
        {
            this.Produtos = new List<InputProdutoNota>();
        }

        public void GravarProduto(InputProdutoNota inputProduto)
        {
            if (!this.Produtos.Contains(inputProduto))
            {
                this.Produtos.Add(inputProduto);
            }
        }

        public void RemoverProduto(InputProdutoNota produto)
        {
            this.Produtos.Remove(produto);
        }

        public void RemoverTodos()
        {
            this.Produtos.Clear();
        }
    }
}
