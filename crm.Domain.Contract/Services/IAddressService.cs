using crm.Data.Contract.Models;

namespace crm.Domain.Contract.Services
{
    public interface IAddressService
    {
        Task<IEnumerable<Address>> GetAll();
        Task<Address> Get(string id);
        Task<Address> Create(Address address);
        Task<IEnumerable<Address>> SaveAll(IEnumerable<Address> addresses);
        Task<Address> Update(Customer customer);
        Task Delete(string id);
    }
}

