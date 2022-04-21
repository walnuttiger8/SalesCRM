using Application.Repository.Base;
using Application.UseCases.Base;
using Domain.Models.Base;
using Infrastructure.Repository.Base;
using Moq;
using NUnit.Framework;
using System.Linq;

namespace Tests.Application.UseCases.Base
{
    public class TestDeleteModelUseCase<T> where T : BaseModel
    {
        protected IRepository<T> _repository;
        protected DeleteModelUseCase<T> _useCase;

        protected virtual IRepository<T> CreateRepository()
        {
            return new MemoryRepository<T>();
        }
        protected virtual DeleteModelUseCase<T> CreateUseCase()
        {
            return new DeleteModelUseCase<T>(_repository);
        }
        [SetUp]
        public void SetUp()
        {
            _repository = CreateRepository();
            _useCase = CreateUseCase();
        }

        [Test]
        public void TestDeleted()
        {
            var model = Mock.Of<T>();
            _repository.Add(model);

            var request = new DeleteModelRequest<T>(model);
            _useCase.Execute(request);
        }

        [Test]
        public void TestRemovedFromRepository()
        {
            var model = Mock.Of<T>();
            _repository.Add(model);

            var beforeExecute = _repository.GetAll().ToList().Count;

            var request = new DeleteModelRequest<T>(model);
            _useCase.Execute(request);

            var afterExecute = _repository.GetAll().ToList().Count;

            Assert.IsTrue(beforeExecute > afterExecute);
        }

        [Test]
        public void TestNotDeletedFromRepository()
        {
            for (int _ = 0; _ < 2; _++)
            {
                _repository.Add(Mock.Of<T>());
            }
            var model = Mock.Of<T>();

            var before = _repository.GetAll().ToList().Count;

            var request = new DeleteModelRequest<T>(model);
            _useCase.Execute(request);

            var after = _repository.GetAll().ToList().Count;

            Assert.IsTrue(before == after);
        }
    }
}
