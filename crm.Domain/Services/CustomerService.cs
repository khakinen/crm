using crm.Data.Contract;
using crm.Data.Contract.Models;
using crm.Domain.Contract.Services;

namespace crm.Domain.Implementation.Services;

public class CustomerService : ICustomerService
{
    private readonly IUnitOfWork _unitOfWork;

    public CustomerService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Customer> Create(Customer customer)
    {
        var createdCustomer = await CreateCustomerWithAddress(customer);

        await _unitOfWork.Save();

        return createdCustomer;
    }


    public async Task Delete(Guid id)
    {
        await _unitOfWork.CustomerRepository.Delete(id);
    }

    public async Task<Customer> Get(Guid id)
    {
        return await _unitOfWork.CustomerRepository.Get(id);
    }

    public async Task<IEnumerable<Customer>> GetAll()
    {
        return await _unitOfWork.CustomerRepository.GetAll();
    }

    public async Task<IEnumerable<Customer>> SaveAll(IEnumerable<Customer> customers)
    {
        var createdCustomers = new List<Customer>();

        foreach (var customer in customers)
        {
            createdCustomers.Add(await CreateCustomerWithAddress(customer));
        }

        await _unitOfWork.Save();

        return createdCustomers;
    }

    public async Task<Customer> Update(Guid id, Customer customer)
    {
        return await _unitOfWork.CustomerRepository.Update(id, customer);
    }

    private async Task<Customer> CreateCustomerWithAddress(Customer customer)
    {
        foreach (var address in customer.Addresses)
        {
            var existingAddress = _unitOfWork.AddressRepository.Get(address.Id);

            if (existingAddress == null)
            {
                await _unitOfWork.AddressRepository.Create(address);
            }
        }

        return await _unitOfWork.CustomerRepository.Create(customer);
    }
}


