using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinojunior.ProjectModel
{
    public class Produto
    {
        public Guid ID { get; set; }
        public string Descricao { get; set; }
        public double PrecoCusto { get; set; }
        public double PrecoVenda { get; set; }
        public double Estoque { get; set; }

    }
}
