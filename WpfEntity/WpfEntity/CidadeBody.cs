using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfEntity.POCO;

namespace WpfEntity
{
    public class BodyCidades
    {
        public long Id { get; set; }
        public string Nome { get; set; }

        public long EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
