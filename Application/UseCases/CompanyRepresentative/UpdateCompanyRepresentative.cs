using Application.Repository.Base;
using Application.UseCases.Base;
using Domain.Models;

namespace Application.UseCases.UpdateCompanyRepresentative
{
    public class UpdateCompanyRepresentative : UpdateModelUseCase<CompanyRepresentative>
    {
        public UpdateCompanyRepresentative(IRepository<CompanyRepresentative> repository) : base(repository)
        {
        }
    }
}
