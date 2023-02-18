using crm.Data.Contract.Models;

namespace crm.Domain.Contract.Services;


public interface ICustomerService
{
    Task<IEnumerable<Customer>> GetAll();
    Task<Customer> Get(Guid id);
    Task<Customer> Create(Customer customer);
    Task<IEnumerable<Customer>> SaveAll(IEnumerable<Customer> customer);
    Task<Customer> Update(Guid id, Customer customer);
    Task Delete(Guid id);
}

