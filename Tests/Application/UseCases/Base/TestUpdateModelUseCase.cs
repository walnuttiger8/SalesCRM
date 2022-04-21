using Application.Repository.Base;
using Application.UseCases.Base;
using Domain.Models.Base;
using Infrastructure.Repository.Base;
using NUnit.Framework;

namespace Tests.Application.UseCases.Base
{
    public abstract class TestUpdateModelUseCase<T> where T : BaseModel
    {
        protected IRepository<T> _repository;
        protected UpdateModelUseCase<T> _useCase;

        protected virtual IRepository<T> CreateRepository()
        {
            return new MemoryRepository<T>();
        }
        protected virtual UpdateModelUseCase<T> CreateUseCase(IRepository<T> repository)
        {
            return new UpdateModelUseCase<T>(repository);
        }

        [SetUp]
        public void SetUp()
        {
            _repository = CreateRepository();
            _useCase = CreateUseCase(_repository);
        }

        [Test]
        public void TestUpdated()
        {

        }

        [Test]
        public void TestNewDataInRepository()
        {

        }
    }
}
