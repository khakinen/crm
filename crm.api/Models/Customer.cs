using System;
using crm.Data.Contract.Models;

namespace crm.api.Models;

public class Customer
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }

    public IEnumerable<Address> Addresses { get; set; }
}
