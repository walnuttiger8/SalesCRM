using Application.Repository.Base;
using Domain.Models;

namespace Application.Repository
{
    public interface IContactRepository : IRepository<Contact>
    {
        public IEnumerable<Contact> GetByCompanyRepresentative(CompanyRepresentative companyRepresentative);
    }
}
