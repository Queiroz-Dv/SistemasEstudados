﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinojunior.ProjectModel
{
    public class ProdutoNotaEntrada
    {
        public long? ID { get; set; }
        public Produto ProdutoNota { get; set; }
        public double PrecoCustoCompra { get; set; }
        public double QuantidadeComprada { get; set; }
        
        public ProdutoNotaEntrada()
        {
            this.ID = null;
        }
    }
}
