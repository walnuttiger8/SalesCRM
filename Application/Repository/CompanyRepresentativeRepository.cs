using Application.Repository.Base;
using Domain.Models;

namespace Application.Repository
{
    public interface ICompanyRepresentativeRepository : IRepository<CompanyRepresentative>
    {
        public IEnumerable<CompanyRepresentative> GetByCompany(Company company);
    }
}
