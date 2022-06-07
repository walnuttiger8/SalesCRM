using Application.Repository.Base;
using Application.UseCases.Base;
using Domain.Models;

namespace Application.UseCases.CompanyUseCases
{
    public class CreateCompany : CreateModelUseCase<Domain.Models.Company>
    {
        public CreateCompany(IRepository<Domain.Models.Company> repository) : base(repository) { }
    }
}
