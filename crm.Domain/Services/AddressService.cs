using crm.Data.Contract.Models;
using crm.Domain.Contract.Services;

namespace crm.Domain.Implementation.Services;

public class AddressService : IAddressService
{
    public Task Delete(string id)
    {
        throw new NotImplementedException();
    }

    public Task<Address> Get(string id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Address>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Address> Create(Address address)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Address>> SaveAll(IEnumerable<Address> addresses)
    {
        throw new NotImplementedException();
    }

    public Task<Address> Update(Customer customer)
    {
        throw new NotImplementedException();
    }
}


