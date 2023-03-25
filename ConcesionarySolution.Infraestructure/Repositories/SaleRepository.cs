using ConcesionarySolution.Domain.Entities;
using ConcesionarySolution.Domain.Interfaces.Repositories;
using ConcesionarySolution.Infraestructure.Persitence;
using Microsoft.EntityFrameworkCore;

namespace ConcesionarySolution.Infraestructure.Repositories
{
    public class SaleRepository: ISaleRepository
    {
        private readonly ConsesionaryContext _context;
        public SaleRepository(ConsesionaryContext context) 
        {
            _context = context;
        }

        public Sale AddSaleAsync(Sale sale)
        {
            _context.Sales.Add(sale);
            _context.SaveChanges();
            return sale;
            
        }

        public IEnumerable<Sale> GetAllSaleAsync()
        {
            try
            {
                var sales = _context.Sales.ToList();
                return sales;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        public bool DeleteSaleAsync(int saleId)
        {
            var sale = _context.Sales.FirstOrDefault(x => x.SaleId == saleId);
            if (sale == null)
                return false;

            _context.Sales.Remove(sale);
            _context.SaveChanges();
            return true;
        }
       
    }
}
