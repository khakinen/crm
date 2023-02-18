using AutoMapper;
using Api = crm.api.Models;
using DomainModel = crm.Data.Contract.Models;

namespace crm.api.Models;

public class ApiMappingProfile : Profile
{
    public ApiMappingProfile()
    {
        CreateMap<Api.Address, DomainModel.Address>().ForMember(model => model.Customers, option => option.Ignore());
        CreateMap<Api.Customer, DomainModel.Customer>().ForMember(model => model.Addresses, option => option.Ignore());

        CreateMap<DomainModel.Address, Api.Address>();
        CreateMap<DomainModel.Customer, Api.Customer>();
    }
}