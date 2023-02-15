using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docker.Common.Base.APIClient
{
    public class APIResponse
    {
        public bool IsSuccessful { get; set; }

        public string Result { get; set; }

        public Exception ErrorException { get; set; }

    }
}
