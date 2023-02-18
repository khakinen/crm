using Microsoft.AspNetCore.Mvc;
using crm.Domain.Contract.Services;
using AutoMapper;

using Api = crm.api.Models;
using DomainModel = crm.Data.Contract.Models;

namespace crm.api.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class CustomerController : ControllerBase
{
    private readonly ILogger<CustomerController> _logger;
    private readonly ICustomerService _customerService;
    private readonly IMapper _mapper;

    public CustomerController(ILogger<CustomerController> logger, ICustomerService customerService, IMapper mapper)
    {
        _logger = logger;
        _customerService = customerService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IEnumerable<Api.Customer>> Get()
    {

        var customers = await _customerService.GetAll();

        return customers.Select(s => _mapper.Map<Api.Customer>(s));
    }

    [HttpGet("{id}")]
    public async Task<Api.Customer> Get(Guid id)
    {
        var customer = await _customerService.Get(id);

        return _mapper.Map<Api.Customer>(customer);
    }

    [HttpPut("{id}")]
    public async Task<Api.Customer> Update(Guid id, Api.Customer customer)
    {
        var domainCustomer = _mapper.Map<DomainModel.Customer>(customer);

        var updatedCustomer = await _customerService.Update(id, domainCustomer);

        return _mapper.Map<Api.Customer>(updatedCustomer);
    }

    [HttpPost]
    public async Task<Api.Customer> Create(Api.Customer customer)
    {
        var domainCustomer = _mapper.Map<DomainModel.Customer>(customer);

        var createdCustomer = await _customerService.Create(domainCustomer);

        return _mapper.Map<Api.Customer>(createdCustomer);
    }

    [HttpDelete("{id}")]
    public Task Delete(Guid id)
    {
        return _customerService.Delete(id);
    }
}