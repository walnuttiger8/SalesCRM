using Domain.Models.Base;

namespace Domain.Models
{
    public class CompanyRepresentative : BaseModel
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public Guid ContactDataId { get; set; }
        public ContactData ContactData { get; set; }
        public Guid CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public string Comment { get; set; }

        public CompanyRepresentative(string lastName, string firstName, string middleName, ContactData contactData, string comment, Company company) : base()
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            ContactData = contactData;
            Comment = comment;
            Company = company;
        }

        public CompanyRepresentative() { }
    }
}
