using Domain.Models.Base;

namespace Application.Repository.Base
{
    public interface IRepository<T> where T : BaseModel
    {
        T? GetById(Guid id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
