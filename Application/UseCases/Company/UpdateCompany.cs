using Application.Repository.Base;
using Application.UseCases.Base;
using Domain.Models;

namespace Application.UseCases.CompanyUseCases
{
    public class UpdateCompany : UpdateModelUseCase<Domain.Models.Company>
    {
        public UpdateCompany(IRepository<Domain.Models.Company> repository) : base(repository) { }
    }
}
