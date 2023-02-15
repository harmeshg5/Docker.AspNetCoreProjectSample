using Docker.Services.Features.Customer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Docker.Services.Features.Customer
{
    public class CustomerService : ICustomerService
    {
        private List<CustomerModel> _customers;

        public CustomerService()
        {
            _customers = CustomerData();
        }

        public CustomerModel GetCustomer(int ID)
        {
            return _customers.FirstOrDefault(x => x.ID == ID);
        }

        public IEnumerable<CustomerModel> GetCustomers()
        {
            return _customers;
        }

        private List<CustomerModel> CustomerData()
        {
            return new List<CustomerModel>()
            {
                new CustomerModel()
                {
                     Address = "Delhi",
                     Email = "abcd@abcd.com",
                     ID= 1,
                     Name ="James",
                     PhoneNumber = "1233433433"
                },
                new CustomerModel()
                {
                     Address = "Mumai",
                     Email = "aWERE@abcd.com",
                     ID= 2,
                     Name ="MaryJames",
                     PhoneNumber = "2233433433"
                },
                new CustomerModel()
                {
                     Address = "Jaipur",
                     Email = "operd@abcd.com",
                     ID= 3,
                     Name ="JKerymes",
                     PhoneNumber = "5451233433433"
                },
                new CustomerModel()
                {
                     Address = "Dubai",
                     Email = "dubai@abcd.com",
                     ID= 4,
                     Name ="DubaiJames",
                     PhoneNumber = "1454433433"
                },
            };

        }
    }
}
