﻿using System.Web;
using System.Web.Mvc;

namespace labs_73_MVC_Framework_Northwind
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
