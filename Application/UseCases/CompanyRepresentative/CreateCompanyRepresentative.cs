using Application.Repository.Base;
using Application.UseCases.Base;
using Domain.Models;

namespace Application.UseCases.CompanyRepresentativeUseCases
{
    public class CreateCompanyRepresentative : CreateModelUseCase<CompanyRepresentative>
    {
        public CreateCompanyRepresentative(IRepository<CompanyRepresentative> companyRepresentativeRepository) : base(companyRepresentativeRepository) { }
    }
}
