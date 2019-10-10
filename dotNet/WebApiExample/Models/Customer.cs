using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApiExample.Models
{
public class Customer{
    public long Id {get; set;}
    public string FirstName {get; set;}
    public string LastName{get; set;}
    public string Email{get; set;}
}
}