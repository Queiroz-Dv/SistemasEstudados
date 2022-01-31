using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace WpfEntity.POCO
{
    public class EFContext : DbContext
    {
        public EFContext() : base("EF_Intro")
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<EFContext>());
        }

        public DbSet<Estado> Estados { get; set; }
        public DbSet<BodyCidades> Cidades { get; set; }
    }

    public class EFInitizalizer : DropCreateDatabaseAlways<EFContext>
    {
        protected override void Seed(EFContext context)
        {
            IList<Estado> estados = new List<Estado>();
            estados.Add(new Estado()
            {
                UF = "PR",
                Nome = "Paraná"
            });
            estados.Add(new Estado()
            {
                UF = "SC",
                Nome = "Santa Catarina"
            });
            estados.Add(new Estado()
            {
                UF = "SP",
                Nome = "São Paulo"
            });
            estados.Add(new Estado()
            {
                UF = "MS",
                Nome = "Mato Grosso do Sul"
            });
            estados.Add(new Estado()
            {
                UF = "CE",
                Nome = "Ceará"
            });

            foreach (var estado in estados)
            {
                context.Estados.Add(estado);
            }

            IList<BodyCidades> cidades = new List<BodyCidades>();
            cidades.Add(new BodyCidades()
            {
                Estado = estados[0],
                Nome = "Foz do Iguaçu"
            });
            cidades.Add(new BodyCidades()
            {
                Estado = estados[1],
                Nome = "Blumenau"
            });
            cidades.Add(new BodyCidades()
            {
                Estado = estados[2],
                Nome = "Itapetininga"
            });
            cidades.Add(new BodyCidades()
            {
                Estado = estados[3],
                Nome = "Três Lagoas"
            });
            cidades.Add(new BodyCidades()
            {
                Estado = estados[4],
                Nome = "Fortaleza"
            });
            foreach (var cidade in cidades)
            {
                context.Cidades.Add(cidade);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
