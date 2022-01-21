using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinojunior.ProjectModel
{
    class Fornecedor
    {
        //Guid representa um número interior de 16 bytes que pode ser usado
        //como indentificador 
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
    }
}
