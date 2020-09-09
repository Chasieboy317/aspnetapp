using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace aspnetapp
{
    public class HelloWorldController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public string WelcomeSafe(string name = "", int id = 0)
        {
            return HtmlEncoder.Default.Encode($"Welcome {name}, your id is: {id}");
        }

        public string WelcomeUnsafe(string name = "", int id = 0)
        {
            //return ($"Welcome {name}, your id is: {id}");
            return name;
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