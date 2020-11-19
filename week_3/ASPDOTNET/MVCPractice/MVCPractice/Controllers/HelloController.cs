using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPractice.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Action1()
        {

            Console.WriteLine("action method?");
            return new ContentResult
            {
                Content = "web page",
                ContentType = "text",
                StatusCode = StatusCodes.Status200OK
            };
        }

        public IActionResult ParameterizedAction(string param1 = "", int param2 = 0)
        {
            return new ContentResult
            {
                Content = $"Parameter 1 {param1} Parameter 2 {param2}",
                ContentType = "text",
                StatusCode = StatusCodes.Status200OK
            };
        }
    }
}
