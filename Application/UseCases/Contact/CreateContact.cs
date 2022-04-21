using Application.Repository.Base;
using Application.UseCases.Base;
using Domain.Models;

namespace Application.UseCases.ContactUseCases
{
    public class CreateContact : CreateModelUseCase<Contact>
    {
        public CreateContact(IRepository<Contact> repository) : base(repository)
        {
        }
    }
}
