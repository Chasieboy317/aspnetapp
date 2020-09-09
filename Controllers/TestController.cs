using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspnetapp
{
    public class TestController : Controller
    {
        public string Index()
        {
            return "test here";
        }
    }
}