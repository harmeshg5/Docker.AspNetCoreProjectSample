using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docker.Common.Base.APIClient
{
    public interface IAPIClient
    {
        APIResponse GetAPICall(string baseUrl, string action, object body, string userName, string password);

        APIResponse PostAPICall(string baseUrl, string action, object body, string userName, string password);
    }
}
