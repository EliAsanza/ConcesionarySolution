using ConcesionarySolution.Domain.Entities;
using ConcesionarySolution.Domain.Interfaces.Repositories;
using ConcesionarySolution.Domain.Interfaces.Services;

namespace ConcesionarySolution.Application.Services
{
    public  class SaleService: ISaleService
    {
        private readonly ISaleRepository _saleRepository;

        public SaleService(ISaleRepository saleRepository)
        {
            _saleRepository = saleRepository;
        }

        public Sale AddSaleAsync(Sale sale)
        {
            return _saleRepository.AddSaleAsync(sale);
        }

        public bool DeleteSaleAsync(int saleId)
        {
            return  _saleRepository.DeleteSaleAsync(saleId);
        }

        public IEnumerable<Sale> GetAllSaleAsync()
        {
            var sales = _saleRepository.GetAllSaleAsync();
            return sales;
        }

       
    }
}
