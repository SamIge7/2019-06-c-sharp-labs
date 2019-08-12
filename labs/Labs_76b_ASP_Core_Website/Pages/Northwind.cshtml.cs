using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Labs_76b_ASP_Core_Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Labs_76b_ASP_Core_Website.Pages
{
    public class NorthwindModel : PageModel
    {
        public List<Customer> customers = new List<Customer>();
        public void OnGet()
        {
            using(var db = new Northwind())
            {
                customers = db.Customers.ToList();
            }
        }
    }
}