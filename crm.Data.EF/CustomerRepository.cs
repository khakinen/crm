using crm.Data.Contract;
using crm.Data.Contract.Models;

namespace crm.Data.EF;

public class CustomerRepository : ICustomerRepository
{
    public Task<Customer> Create(Customer customer)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Customer> Get(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Customer>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Customer>> SaveAll(IEnumerable<Customer> customer)
    {
        throw new NotImplementedException();
    }

    public Task<Customer> Update(Guid id, Customer customer)
    {
        throw new NotImplementedException();
    }
}

