using NUnit.Framework;
using Domain.Models;

namespace Tests.Domain.Models
{
    public class TestCompany
    {
        [Test]
        public void TestAddRepresentative()
        {
            var company = new Company()
            {
                Name = "Test",
                Description = "Test descr",
                Comment = "Comment",
            };
            var representative = new CompanyRepresentative()
            {
                LastName = "Test",
                FirstName = "Test",
                MiddleName = "Test", 
                ContactData = new ContactData() { Data = "test" },
                Comment = "Test"
            };
            company.AddRepresentative(representative);
            Assert.AreEqual(company.CompanyRepresentatives[0], representative);
        }

        [Test]
        public void TestRemoveRepresentative()
        {
            var company = new Company()
            {
                Name = "Test",
                Description = "Test descr",
                Comment = "Comment",
            };
            var representative = new CompanyRepresentative()
            {
                LastName = "Test",
                FirstName = "Test",
                MiddleName = "Test",
                ContactData = new ContactData() { Data = "test" },
                Comment = "Test"
            };
            company.RemoveRepresentative(representative); // should do nothing 
            company.AddRepresentative(representative);
            company.RemoveRepresentative(representative);

            Assert.IsEmpty(company.CompanyRepresentatives);
        }
    }
}
