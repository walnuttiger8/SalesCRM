using Domain.Models.Base;

namespace Domain.Models
{
    public class User : BaseModel
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public List<Company> Companies { get; set; } = new();
    }
}
