
using ConcesionarySolution.Domain.Entities;

namespace ConcesionarySolution.Domain.Interfaces.Repositories
{
    public interface ISaleRepository
    {
        IEnumerable<Sale> GetAllSaleAsync();
        Sale AddSaleAsync(Sale sale);
        bool DeleteSaleAsync(int saleId);
    }
}
