using Docker.Services.Features.Customer;
using Docker.Services.Features.Customer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dcoker.Services.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICustomerService _customerService;

        public HomeController(ILogger<HomeController> logger, ICustomerService customerService)
        {
            _logger = logger;
            _customerService = customerService;
        }

        [HttpGet]
        public string View()
        {
            return "Hello World from controller";
        }

        [HttpGet]
        public ActionResult<IEnumerable<CustomerModel>> GetAllCustomers()
        {
            var item = _customerService.GetCustomers();

            return Ok(item);
        }

        [HttpGet("{id}")]
        public ActionResult<CustomerModel> GetCustomerbyId(int id)
        {
            var item = _customerService.GetCustomer(id);

            return Ok(item);
        }
    }

}
