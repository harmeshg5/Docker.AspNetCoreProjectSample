using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Docker.Common.Base.APIClient
{
    public class APIClient : IAPIClient
    {

        private readonly IRestClient _restClient;

        public HttpBasicAuthenticator BasicAuthenticator { get; set; }

        public APIClient(IRestClient restClient)
        {
            _restClient = restClient;
        }


        public APIResponse GetAPICall(string baseUrl, string action, object body, string userName, string password)
        {
            return APICall(Method.GET, baseUrl, action, body, userName, password);
        }

        public APIResponse PostAPICall(string baseUrl, string action, object body, string userName, string password)
        {
            return APICall(Method.POST, baseUrl, action, body, userName, password);
        }

        public APIResponse APICall(Method method, string baseUrl, string action, object body, string userName, string password)
        {
            APIResponse response1 = new APIResponse();
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string endpoint = baseUrl + action;
                    //client.BaseAddress = new Uri(baseUrl);

                    var respose = client.GetAsync(endpoint).Result;

                    //respose.Wait();

                    //if (respose.IsCompletedSuccessfully)
                    //{
                    //    //response1.IsSuccessful = respose.IsCompletedSuccessfully;
                    //    //response1.Result = respose.Result.ToString();
                    //    //response1.ErrorException = null;
                    //};


                }
                catch (Exception ex)
                {

                    throw;
                }
            }


            RestRequest request = new RestRequest(action, method)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = new RestSharp.Serialization.Json.JsonSerializer()
            };

            if (body != null)
            {
                request.AddBody(body);
            }

            request.JsonSerializer.ContentType = "application/json; charset=utf-8";

            _restClient.BaseUrl = new Uri(baseUrl);
            // _restClient.Authenticator = new HttpBasicAuthenticator(userName, password);

            var response = _restClient.Execute(request);

            return new APIResponse()
            {
                IsSuccessful = response.IsSuccessful,
                Result = response.Content,
                ErrorException = response.ErrorException
            };
        }

    }
}
