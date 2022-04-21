using Domain.Models.Base;

namespace Domain.Models
{
    public class ContactData : BaseModel
    {
        public Guid CompanyRepresentativeId { get; set; }
        public string Data { get; set; }
    }
}
