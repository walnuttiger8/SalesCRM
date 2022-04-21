using Application.Repository.Base;
using Domain.Models.Base;

namespace Application.UseCases.Base
{
    public class DeleteModelRequest<T> where T : BaseModel
    {
        public T Model { get; set; }

        public DeleteModelRequest(T model)
        {
            Model = model;
        }
    }

    public class DeleteModelResponse<T> where T : BaseModel { }
    public class DeleteModelUseCase<T> where T : BaseModel
    {
        protected IRepository<T> _repository;

        public DeleteModelUseCase(IRepository<T> repository)
        {
            _repository = repository;
        }
        public DeleteModelResponse<T> Execute(DeleteModelRequest<T> request)
        {
            _repository.Delete(request.Model);
            return new DeleteModelResponse<T>();
        }
    }
}
