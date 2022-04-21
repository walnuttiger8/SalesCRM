using Application.Repository.Base;
using Application.UseCases.Base;
using Domain.Models;

namespace Application.UseCases.DeleteCompanyRepresentative
{
    public class DeleteCompanyRepresentative : DeleteModelUseCase<CompanyRepresentative>
    {
        public DeleteCompanyRepresentative(IRepository<CompanyRepresentative> repository) : base(repository)
        {
        }
    }
}
