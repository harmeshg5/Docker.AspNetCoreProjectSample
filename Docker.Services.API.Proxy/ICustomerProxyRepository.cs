using Docker.Services.API.Proxy.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docker.Services.API.Proxy
{
    public interface ICustomerProxyRepository
    {
        List<CustomerDomain> GetCustomers();
        CustomerDomain GetCustomerByID(int id);
    }
}
