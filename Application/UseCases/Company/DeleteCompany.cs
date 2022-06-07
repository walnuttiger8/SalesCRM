using Application.Repository.Base;
using Application.UseCases.Base;
using Domain.Models;

namespace Application.UseCases.DeleteCompany
{
    public class DeleteCompany : DeleteModelUseCase<Domain.Models.Company>
    {
        public DeleteCompany(IRepository<Domain.Models.Company> repository) : base(repository)
        {
        }
    }
}
