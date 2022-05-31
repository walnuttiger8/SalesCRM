using Application.Repository.Base;
using Domain.Models.Base;

namespace Application.UseCases.Base
{
    public class GetAllModelsResponse<T> where T : BaseModel
    {
        public List<T> Result;

        public GetAllModelsResponse(List<T> result)
        {
            Result = result;
        }
    }

    public class GetAllModelsRequest<T> where T : BaseModel { }

    public class GetAllModelsUseCase<T> where T: BaseModel
    {
        protected IRepository<T> _repository;

        public GetAllModelsUseCase(IRepository<T> repository)
        {
            this._repository = repository;
        }

        public GetAllModelsResponse<T> Execute(GetAllModelsRequest<T> request) 
        {
            var result = _repository.GetAll().ToList();
            return new GetAllModelsResponse<T>(result);
        }
    }
}
