using Application.Repository.Base;
using Domain.Models.Base;

namespace Application.UseCases.Base
{
    public class UpdateModelRequest<T> where T : BaseModel
    {
        public T Model { get; set; }
    }
    public class UpdateModelResponse<T> where T : BaseModel { }
    public class UpdateModelUseCase<T> where T : BaseModel
    {
        protected IRepository<T> _repository;

        public UpdateModelUseCase(IRepository<T> repository)
        {
            _repository = repository;
        }

        public UpdateModelResponse<T> Execute(UpdateModelRequest<T> request)
        {
            _repository.Update(request.Model);
            return new UpdateModelResponse<T>();
        }
    }
}
