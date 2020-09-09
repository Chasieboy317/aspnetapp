using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspnetapp
{
    public class HelloWorldController : Controller
    {

        public string Index()
        {
            return "Hi here";
        }

        public string Welcome()
        {
            return "Welcome here";
        }

        public string Goodbye() {
            return "Goodbye here";
        }

        //public IActionResult Index()
        //{
            //return View();
        //}
    }
}