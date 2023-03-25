namespace ConcesionarySolution.Domain.Entities
{
    public class Car
    {
        public int CarId { get; set; }
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Revision>? Revisions { get; set; }
    }
}