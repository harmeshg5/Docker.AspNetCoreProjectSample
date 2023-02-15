using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docker.Common.Base.AppSettings
{
    public class AppSettings : IAppSettings
    {

        public string DatabaseConnectionString { get; set; }
        public AzureStorage AzureStorage { get; set; }
        public AzureServiceBus AzureServiceBus { get; set; }
        public CustomerServiceAPI CustomerServiceAPI { get; set; }

        public AppSettings(IConfiguration configuration)
        {
            AzureServiceBus = new AzureServiceBus();
            AzureStorage = new AzureStorage();
            CustomerServiceAPI = new CustomerServiceAPI();

            BuildConfiguration(configuration);
        }

        private void BuildConfiguration(IConfiguration configuration)
        {

            this.DatabaseConnectionString = configuration.GetSection("DatabaseConnectionString").Value;

            configuration.Bind("AzureServiceBus", AzureServiceBus);
            configuration.Bind("AzureStorage", AzureStorage);
            configuration.Bind("CustomerServiceAPI", CustomerServiceAPI);

        }

    }
}
