namespace ConcesionarySolution.Domain.Entities
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int CustomerId{get; set;}
        public virtual Customer Customer { get; set; }
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
    }
}
