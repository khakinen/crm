namespace crm.Data.Contract;

public interface IUnitOfWork
{
    ICustomerRepository CustomerRepository { get; }

    IAddressRepository AddressRepository { get; }

    Task Save();
}

