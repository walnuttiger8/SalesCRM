using Application.Repository.Base;
using Application.UseCases.Base;
using Domain.Models.Base;
using Infrastructure.Repository.Base;
using Moq;
using NUnit.Framework;
namespace Tests.Application.UseCases.Base
{
    public abstract class TestCreateModelUseCase<T> where T : BaseModel
    {
        protected IRepository<T> _repository;
        protected CreateModelUseCase<T> _useCase;

        protected virtual IRepository<T> CreateRepository()
        {
            return new MemoryRepository<T>();
        }
        protected virtual CreateModelUseCase<T> CreateUseCase()
        {
            return new CreateModelUseCase<T>(_repository);
        }

        [SetUp]
        public void SetUp()
        {
            _repository = CreateRepository();
            _useCase = CreateUseCase();
        }

        [Test]
        public virtual void TestCreated()
        {
            var model = Mock.Of<T>();
            var request = new CreateModelRequest<T>(model);
            var response = _useCase.Execute(request);

            Assert.AreEqual(response.Result, model);
        }

        [Test]
        public virtual void TestAddedToRepository()
        {
            var model = Mock.Of<T>();
            var request = new CreateModelRequest<T>(model);
            var response = _useCase.Execute(request);

            Assert.IsNotNull(_repository.GetById(response.Result.Id));
        }
    }
}
