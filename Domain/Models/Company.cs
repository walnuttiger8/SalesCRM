using Domain.Models.Base;

namespace Domain.Models
{
    public class Company : BaseModel
    {
        public string Name { get; set; }
        public string INN { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }

        public List<CompanyRepresentative> CompanyRepresentatives { get; set; } = new List<CompanyRepresentative>();

        public Company(string name, string inn, string description, string comment, List<CompanyRepresentative> companyRepresentatives) : base()
        {
            Name = name;
            INN = inn;
            Description = description;
            Comment = comment;
            CompanyRepresentatives = companyRepresentatives;
        }

        public Company() { }

        public void AddRepresentative(CompanyRepresentative companyRepresentative)
        {
            CompanyRepresentatives.Add(companyRepresentative);
        }

        public void RemoveRepresentative(CompanyRepresentative companyRepresentative)
        {
            CompanyRepresentatives.Remove(companyRepresentative);
        }
    }
}
