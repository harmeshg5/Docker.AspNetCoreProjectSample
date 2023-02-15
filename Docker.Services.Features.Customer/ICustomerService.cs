using Docker.Services.Features.Customer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docker.Services.Features.Customer
{
    public interface ICustomerService
    {
        IEnumerable<CustomerModel> GetCustomers();

        CustomerModel GetCustomer(int ID);
    }
}
