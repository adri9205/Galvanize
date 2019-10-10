using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApiExample.Models;

namespace WebApiExample.Controllers
{
    
    [ApiController]
    //[Route("api/[controller]")]
    public class CustomerController: ControllerBase
    {
        public List<Customer> customers; 

    public CustomerController()
    {
        this.customers = new List<Customer>{
            new Customer {Id=1, FirstName="Steve", LastName="Bishop", Email="steve.bishop@galvanize.com"},
            new Customer {Id=2, FirstName="Adriana", LastName="Cortes", Email="adriana.cortess@cemex.com"}
        };
    }
        [HttpGet("api/customer/{id}")]
        public Object Read([FromRoute] long id)
        {
           // var data =new {Id=id, FirstName="Steve", LastName="Bishop", Email="steve.bishop@galvanize.com"};
            //var data =new {Id=id, FirstName=name, LastName=lastname, Email=email};
            foreach(Customer customer in customers){
                if (customer.Id==id){
                    return customer;
                }
            }
            return null;
        }
        [HttpGet("api/customer")]
        public List<Customer> GetALL()
        {
            //var data =new {id=1, firstName="Steve", lastName="Bishop", email="steve.bishop@galvanize.com"};
            return this.customers;//data;
        }
        [HttpPost("api/customer")]
        public Customer Create([FromBody]Customer newCustomer)
        {
            newCustomer.Id= customers.Count()+1;
           // Customer newCustomer = new Customer{Id=customers.Count()+1, FirstName="Steve", LastName="Bishop", Email="steve.bishop@galvanize.com"};
            this.customers.Add(newCustomer);
            foreach (Customer customer in this.customers)
            {
                if (customer.Id==newCustomer.Id)
                {
                    return customer;
                }
               

            }
            return null;
        }
        [HttpPut ("api/Customer/{id}")]

        public string Update([FromRoute]long id, [FromBody]Customer updatedCus){
          
            foreach (Customer customer in customers)
            {
                if (customer.Id==id)
                {
                    customer.FirstName=updatedCus.FirstName;
                    customer.LastName=updatedCus.LastName;
                    customer.Email=updatedCus.Email;
                }
               
            }
           
            return "Update";
        }

        [HttpDelete ("api/Customer")]

        public string Delete(){
            
            foreach (Customer customer in customers)
            {
                if (customer.Id!=1)
                {
                    customers.Remove(customer);
                    break;
                }
            }
            
            
            return "Delete";
        }
    }
    
}