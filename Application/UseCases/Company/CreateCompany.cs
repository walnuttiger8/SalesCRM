using Application.Repository.Base;
using Application.UseCases.Base;
using Domain.Models;

namespace Application.UseCases.CompanyUseCases
{
    public class CreateCompany : CreateModelUseCase<Company>
    {
        public CreateCompany(IRepository<Company> repository) : base(repository) { }
    }
}
