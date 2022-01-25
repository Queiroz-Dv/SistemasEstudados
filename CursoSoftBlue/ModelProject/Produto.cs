namespace Treinojunior.ProjectModel
{
    public class Produto
    {
        public long? ID { get; set; }
        public string Descricao { get; set; }
        public double PrecoCusto { get; set; }
        public double PrecoVenda { get; set; }
        public double Estoque { get; set; }

        public Produto()
        {
            this.ID = null;
        }
    }
}
