namespace ConcesionarySolution.Domain.Entities
{
    public class Revision
    {
        public int Revisionid { get; set; }
        public int Quantity { get; set; }
        public bool Filtro { get; set; }
        public bool Oil { get; set; }
        public bool Freno { get; set; }
        public string Other { get; set; }
        public int CarId { get; set; }
        public virtual Car? Car { get; set; }

    }
}
