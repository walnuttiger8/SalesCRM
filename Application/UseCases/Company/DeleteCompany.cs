using Application.Repository.Base;
using Application.UseCases.Base;
using Domain.Models;

namespace Application.UseCases.DeleteCompany
{
    public class DeleteCompany : DeleteModelUseCase<Company>
    {
        public DeleteCompany(IRepository<Company> repository) : base(repository)
        {
        }
    }
}
