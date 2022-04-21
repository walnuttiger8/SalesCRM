using Domain.Models.Base;
using Application.Repository.Base;

namespace Infrastructure.Repository.Base
{
    public class MemoryRepository<T> : IRepository<T> where T : BaseModel
    {
        protected List<T> _items;
        public MemoryRepository()
        {
            _items = new List<T>();
        }
        public void Add(T entity)
        {
            
            _items.Add(entity);
        }

        public void Delete(T entity)
        {
            if (_items.Contains(entity))
                _items.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }

        public T? GetById(Guid id)
        {
            return _items.FirstOrDefault(x => x.Id == id);
        }

        public void Update(T entity)
        {
            var index = _items.FindIndex(x => x.Id == entity.Id);
            if (index >= 0)
                _items[index] = entity;
        }
    }
}
