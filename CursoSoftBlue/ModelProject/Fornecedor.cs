using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinojunior.ProjectModel
{
    public class Fornecedor
    {
        //Guid representa um número interior de 16 bytes que pode ser usado
        //como indentificador 
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }

        protected bool Equals(Fornecedor outro)
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
            if (obj.GetType() != typeof(Fornecedor))
            {
                return false;
            }
            return Equals((Fornecedor)obj);
        }

        public override int GetHashCode()
        {
            return GetHashCode();
        }
    }
}
