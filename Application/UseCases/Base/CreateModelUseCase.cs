using Application.Repository.Base;
using Domain.Models.Base;

namespace Application.UseCases.Base
{
    public class CreateModelRequest<T> where T : BaseModel
    {
        public T Data { get; set; }

        public CreateModelRequest(T data)
        {
            Data = data;
        }
    }

    public class CreateModelResponse<T> where T : BaseModel
    {
        public T Result { get; set; }

        public CreateModelResponse(T result)
        {
            Result = result;
        }
    }

    public class CreateModelUseCase<T> where T : BaseModel
    {
        protected IRepository<T> _repository;

        public CreateModelUseCase(IRepository<T> repository)
        {
            _repository = repository;
        }

        public CreateModelResponse<T> Execute(CreateModelRequest<T> request)
        {
            var model = request.Data;
            _repository.Add(model);
            return new CreateModelResponse<T>(model);
        }
    }
}
