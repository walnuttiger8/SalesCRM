using Application.Repository.Base;
using Domain.Models;

namespace Application.Repository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        Company? GetCompanyByINN(string inn);
    }
}
