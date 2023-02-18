using crm.Data.Contract;
using crm.Data.Contract.Models;

namespace crm.Data.EF;

public class AddressRepository : IAddressRepository
{
    public Task<Address> Create(Address address)
    {
        throw new NotImplementedException();
    }

    public Task Delete(string id)
    {
        throw new NotImplementedException();
    }

    public Task<Address> Get(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Address>> GetAll()
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

