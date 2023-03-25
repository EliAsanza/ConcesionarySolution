using ConcesionarySolution.Domain.Entities;

namespace ConcesionarySolution.Domain.Interfaces.Services
{
    public interface ISaleService
    {
        IEnumerable<Sale> GetAllSaleAsync();
        Sale AddSaleAsync(Sale sale);
        bool DeleteSaleAsync(int saleId);

    }
}
