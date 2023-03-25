﻿namespace ConcesionarySolution.Domain.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Sale>? Sales { get; set; }
    }
}
