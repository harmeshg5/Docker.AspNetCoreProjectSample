using Docker.Common.Base.APIClient;
using Docker.Common.Base.AppSettings;
using Docker.Services.API.Proxy.Domains;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docker.Services.API.Proxy
{
    public class CustomerProxyRepository : ICustomerProxyRepository
    {

        private readonly IAppSettings _appSettings;
        private readonly IAPIClient _apiClient;

        public CustomerProxyRepository(IAppSettings appSettings, IAPIClient apiClient)
        {
            _appSettings = appSettings;
            _apiClient = apiClient;

            _appSettings.CustomerServiceAPI.BaseUrl = "https://localhost:44327/";
            _appSettings.CustomerServiceAPI.GetCustomers = "api/home/Getallcustomers";
            _appSettings.CustomerServiceAPI.GetCustomerByID = "api/home/GetcustomerbyID/";
        }

        public CustomerDomain GetCustomerByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<CustomerDomain> GetCustomers()
        {
            var result = _apiClient.GetAPICall(_appSettings.CustomerServiceAPI.BaseUrl,
                _appSettings.CustomerServiceAPI.GetCustomers, null,
                _appSettings.CustomerServiceAPI.APIUserName,
                _appSettings.CustomerServiceAPI.APIPassword);

            var response = JsonConvert.DeserializeObject<List<CustomerDomain>>(result.Result);

            return response;
        }


        public CustomerDomain GetCustomers(int ID)
        {
            var action = string.Format(_appSettings.CustomerServiceAPI.GetCustomerByID, ID);
            var result = _apiClient.GetAPICall(_appSettings.CustomerServiceAPI.BaseUrl, action, null,
                _appSettings.CustomerServiceAPI.APIUserName,
                _appSettings.CustomerServiceAPI.APIPassword);

            var response = JsonConvert.DeserializeObject<CustomerDomain>(result.Result);

            return response;
        }

    }
}
