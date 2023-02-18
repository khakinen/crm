using crm.Data.Contract.Models;

namespace crm.Data.Contract
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAll();
        Task<Customer> Get(Guid id);
        Task<Customer> Create(Customer customer);
        Task<IEnumerable<Customer>> SaveAll(IEnumerable<Customer> customer);
        Task<Customer> Update(Guid id, Customer customer);
        Task Delete(Guid id);
    }
}