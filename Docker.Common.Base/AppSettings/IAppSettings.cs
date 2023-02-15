using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docker.Common.Base.AppSettings
{
    public interface IAppSettings
    {
        string DatabaseConnectionString { get; set; }

        AzureStorage AzureStorage { get; set; }

        AzureServiceBus AzureServiceBus { get; set; }

        CustomerServiceAPI CustomerServiceAPI { get; set; }

    }

    public class AzureStorage
    {
        public string StorageConnectionString { get; set; }
    }

    public class AzureServiceBus
    {
        public string ServiceBusConnectionString { get; set; }
    }

    public class CustomerServiceAPI
    {
        public string BaseUrl { get; set; }


        public string GetCustomers { get; set; }

        public string GetCustomerByID { get; set; }

        public string APIUserName { get; set; }

        public string APIPassword { get; set; }
    }
}
