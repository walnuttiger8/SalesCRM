using Application.Repository;
using Domain.Models;
using Infrastructure.Repository.Base;

namespace Infrastructure.Repository
{
    public class CompanyRepresentativeMemoryRepository : MemoryRepository<CompanyRepresentative>, ICompanyRepresentativeRepository
    {
        public IEnumerable<CompanyRepresentative> GetByCompany(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
