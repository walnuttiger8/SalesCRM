using Domain.Models.Base;
using Infrastructure.Repository.Base;
using NUnit.Framework;
using System;

namespace Tests.Infrastructure.Base
{
    internal class Model: BaseModel { }
    public class TestMemoryRepository
    {
        [Test]
        public void TestCreate()
        {
            MemoryRepository<Model> repository = new MemoryRepository<Model>();
            Assert.IsNotNull(repository);
        }

        [Test]
        public void TestAddElement()
        {
            MemoryRepository<Model> repository = new MemoryRepository<Model>();

            var model = new Model();
            repository.Add(model);

            Assert.IsNotEmpty(repository.GetAll());
        }

        [Test]
        public void TestUpdate()
        {
            MemoryRepository<Model> repository = new MemoryRepository<Model>();

            var model = new Model();
            repository.Add(model);

            model.Id = new Guid();

            repository.Update(model);
            Assert.IsNotNull(repository.GetById(model.Id));
        }

        [Test]
        public void TestDelete()
        {
            var repository = new MemoryRepository<Model>();

            var model = new Model();

            repository.Add(model);
            repository.Delete(model);

            Assert.IsNull(repository.GetById(model.Id));
        }
    }
}
