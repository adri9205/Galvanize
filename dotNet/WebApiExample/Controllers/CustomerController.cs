using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApiExample.Controllers
{
    [ApiController]
    //[Route("api/[controller]")]
    public class CustomerController: ControllerBase
    {
        [HttpGet("api/customer")]
        public Object Read()
        {
            var data =new {Id=1, FirstName="Steve", LastName="Bishop", Email="steve.bishop@galvanize.com"};
            return data;
        }
        [HttpPost("api/customer")]
        public string Create()
        {
            return "Created";
        }
         [HttpPut("api/customer")]
        public string Update()
        {
            return "Updated";
        }
        [HttpDelete("api/customer")]
        public string Delete()
        {
            return "Deleted";
        }
    }
    
}