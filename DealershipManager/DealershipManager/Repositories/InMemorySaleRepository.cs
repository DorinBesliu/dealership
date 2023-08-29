using DealershipManager.Models;

namespace DealershipManager.Repositories
{
    public class InMemorySaleRepository : ISaleRepository
    {
       private static readonly List<Sale> _sale = new List<Sale>();
        public void Add(Sale sale)
        {
           _sale.Add(sale);
        }

        public List<Sale> GetAll()
        {
            return _sale;
        }
    }
}
