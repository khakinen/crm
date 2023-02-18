using crm.Data.Contract.Models;

namespace crm.Data.Contract
{
    public interface IAddressRepository
    {
        Task<IEnumerable<Address>> GetAll();
        Task<Address> Get(Guid id);
        Task<Address> Create(Address address);
        Task<IEnumerable<Address>> SaveAll(IEnumerable<Address> addresses);
        Task<Address> Update(Customer customer);
        Task Delete(string id);
    }
}