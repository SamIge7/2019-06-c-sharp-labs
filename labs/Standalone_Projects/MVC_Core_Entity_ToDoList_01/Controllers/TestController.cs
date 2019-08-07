using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Core_Entity_ToDoList_01.Models;

namespace MVC_Core_Entity_ToDoList_01.Controllers
{
    public class TestController : Controller
    {
        public Lists myList = new Lists();
        public IActionResult Index()
        {
            myList.stringList = new List<string>() { "one", "two", "three" };
            myList.intList = new List<int>() {1,2,3,4,5,6,7};
            return View(myList);
        }
    }
}