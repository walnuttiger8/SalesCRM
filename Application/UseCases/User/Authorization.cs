using Application.Repository.Base;


namespace Application.UseCases.User
{
    public class AuthorizationRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public AuthorizationRequest(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }

    public class AuthorizationResponse
    {
        public Domain.Models.User? User { get; set; }

        public AuthorizationResponse(Domain.Models.User user)
        {
            User = user;
        }

        public AuthorizationResponse() { }
    }
    public class Authorization
    {
        private IRepository<Domain.Models.User> _repository;
        public Authorization(IRepository<Domain.Models.User> repository)
        {
            _repository = repository;
        }

        public AuthorizationResponse Execute(AuthorizationRequest request)
        {
            var user = _repository.GetAll().Where(u => u.Login == request.Login).FirstOrDefault();

            if (user == null)
            {
                return new AuthorizationResponse();
            }
            return new AuthorizationResponse(user);
        }
    }
}
