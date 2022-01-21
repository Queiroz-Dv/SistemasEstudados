using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinojunior.EstudoPOO
{
    class InputProdutoNota
    {
        public Guid ID { get; set; }
        public Produto ProdutoNota { get; set; }
        public double PrecoCustoCompra { get; set; }
        public double QuantidadeComprada { get; set; }

        protected bool Equals(InputProdutoNota outro)
        {
            return ID.Equals(outro.ID);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != typeof (InputProdutoNota))
            {
                return false;
            }
            return Equals((InputProdutoNota)obj);
        }

        public override int GetHashCode()
        {
            return ProdutoNota.GetHashCode();
        }
    }
}
