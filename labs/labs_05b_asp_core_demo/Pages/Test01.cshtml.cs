﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace labs_05b_asp_core_demo.Pages
{
    public class Test01Model : PageModel
    {
        public string DisplayItem { get; set; }
        public void OnGet()
        {
            DisplayItem = "some text";
        }
    }
}