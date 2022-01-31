using System.Collections.Generic;

namespace WpfEntity.POCO
{
    public class Estado
    {
        public long Id { get; set; }
        public string UF { get; set; }
        public string Nome { get; set; }

        public virtual List<BodyCidades> CidadeBodies { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
