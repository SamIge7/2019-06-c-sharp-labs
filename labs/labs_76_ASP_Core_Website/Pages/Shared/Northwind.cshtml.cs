using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using labs_76_ASP_Core_Website.Pages.Model;


namespace labs_76_ASP_Core_Website.Pages.Shared
{
    public class NorthwindModel : PageModel
    {
        public List<Customer> customers = new List<Customer>();

        public void OnGet()
        {
            using(var db = new NorthwindModel())
            {
                customers = db.customers.ToList();
            }
        }
    }
}