using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using labs_76_ASP_Core_Website.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace labs_76_ASP_Core_Website.Pages
{

    public class NorthwindModel : PageModel
    {
        public List<Customer> customerss = new List<Customer>();
        public void OnGet()
        {
            using (var db = new Northwind())
            {
                customerss = db.customers.ToList();
            }
        }
    }
}