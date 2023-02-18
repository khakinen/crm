using crm.Data.Contract;

namespace crm.Data.EF;

public class UnitOfWork : IUnitOfWork
{

    private readonly ICustomerRepository _customerRepository;
    public readonly IAddressRepository _addressRepository;

    public UnitOfWork(ICustomerRepository customerRepository, IAddressRepository addressRepository)
    {
        _customerRepository = customerRepository;
        _addressRepository = addressRepository;
    }

    public ICustomerRepository CustomerRepository => _customerRepository;

    public IAddressRepository AddressRepository => _addressRepository;

    public Task Save()
    {
        throw new NotImplementedException();
    }
}

