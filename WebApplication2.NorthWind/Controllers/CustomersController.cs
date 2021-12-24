using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Northwind.Bll;
using Northwind.Dal.Concrete.EntityFramework;
using Northwind.Dal.Concrete.EntityFramework.EfRepository;
using Northwind.Entity.Models;
using Northwind.InterfaceLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nortwind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService customerService = new CustomerService(new EfCustomerRepository(new NORTHWNDContext()));
        //public CustomersController(ICustomerService customerService)
        //{
        //    this.customerService = customerService;
        //}

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
                return Ok(customerService.GetAll());
        }
    }
}
