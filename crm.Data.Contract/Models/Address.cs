namespace crm.Data.Contract.Models;

public class Address
{
    public Guid Id { get; set; }
    public int HouseNumber { get; set; }
    public string StreetName { get; set; }
    public string PostCode { get; set; }
    public string City { get; set; }

    public IEnumerable<Customer> Customers { get; set; }
}
