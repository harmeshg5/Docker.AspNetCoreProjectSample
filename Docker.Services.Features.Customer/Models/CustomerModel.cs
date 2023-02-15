﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docker.Services.Features.Customer.Models
{
    public class CustomerModel : BaseModel
    {
        public string Email { get; set; }


        public string PhoneNumber { get; set; }

        public string Address { get; set; }
    }
}
