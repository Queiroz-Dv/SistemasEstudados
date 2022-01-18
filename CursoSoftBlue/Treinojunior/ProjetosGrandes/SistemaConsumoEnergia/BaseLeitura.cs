using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoEnergiaCondominio
{
    class BaseLeitura
    {
        public string Casa { get; set; }
        public double Consumo { get; set; }
        public double Desconto { get { return Consumo * 0.20; } }

        public BaseLeitura(string casa, double consumo)
        {
            this.Casa = casa;
            this.Consumo = consumo;
        }

        public override bool Equals(Object l)
        {
            BaseLeitura leitura = l as BaseLeitura;
            if (leitura == null)
            {
                return false;
            }
            return (Casa.Equals(leitura.Casa));
        }
        public override int GetHashCode()
        {
            return new { Casa, Consumo }.GetHashCode();
        }
    }
}


