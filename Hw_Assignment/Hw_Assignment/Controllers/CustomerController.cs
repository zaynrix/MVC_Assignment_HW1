using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hw_Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hw_Assignment.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult List()
        {
            OurDatabase DB = new OurDatabase();
            List<Customer> Customers;

            Customers = DB.Customers;

            return View(Customers);
        }
    }
}
