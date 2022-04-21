using Domain.Models.Base;

namespace Domain.Models
{
    public class Contact : BaseModel
    {
        public DateTime ContactDate { get; set; } = DateTime.Now;
        public string Comment { get; set; }
        public ContactType ContactType { get; set; }
        public CompanyRepresentative CompanyRepresentative { get; set; }
    }
}
