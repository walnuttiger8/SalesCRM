using Domain.Models;
using Application.Repository;
using Infrastructure.Repository.Base;

namespace Infrastructure.Repository
{
    public class CompanyMemoryRepository : MemoryRepository<Company>, ICompanyRepository
    {
        public Company? GetCompanyByINN(string inn)
        {
            return _items.FirstOrDefault(x => x.INN == inn);
        }
    }
}
