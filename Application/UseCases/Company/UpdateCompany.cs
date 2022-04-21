using Application.Repository.Base;
using Application.UseCases.Base;
using Domain.Models;

namespace Application.UseCases.CompanyUseCases
{
    public class UpdateCompany : UpdateModelUseCase<Company>
    {
        public UpdateCompany(IRepository<Company> repository) : base(repository) { }
    }
}
