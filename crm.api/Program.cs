
using crm.Data.Contract;
using crm.Data.EF;
using crm.Domain.Contract.Services;
using crm.Domain.Implementation.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace crm.api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();

        builder.Services.AddScoped<ICustomerService, CustomerService>();
        builder.Services.AddScoped<IAddressService, AddressService>();
        builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
        builder.Services.AddScoped<IAddressRepository, AddressRepository>();
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


        var connectionString = builder.Configuration.GetConnectionString("CRMDatabase");

        builder.Services.AddDbContext<CrmDbContext>(options =>
            options.UseSqlServer(connectionString));


        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "crm API", Version = "v1" });

        });

        var app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "crm API V1");
        });


        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseEndpoints(e =>
        {
            e.MapControllers();
        });

        app.Run();
    }
}

