using Application.Repository.Base;

namespace Application.UseCases.Company
{

    public class GetCompanyRequest
    {
        public Guid Guid { get; set; }

        public GetCompanyRequest(Guid guid)
        {
            Guid = guid;
        }
    }

    public class GetCompanyResponse
    {
        public Domain.Models.Company? Company { get; set; } 

        public GetCompanyResponse() { }

        public GetCompanyResponse(Domain.Models.Company company)
        {
            Company = company;
        }
    }

    public class GetCompany
    {
        private readonly IRepository<Domain.Models.Company> _repository;
        public GetCompany(IRepository<Domain.Models.Company> repository)
        {
            _repository = repository;
        }

        public GetCompanyResponse Execute(GetCompanyRequest request)
        {
            var company = _repository.GetById(request.Guid);
            if (company == null)
            {
                return new GetCompanyResponse();
            }
            return new GetCompanyResponse(company);
        }
    }
}
