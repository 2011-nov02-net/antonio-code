using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPractice.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return new ContentResult
            {
                Content = "Hello user",
                ContentType = "text",
                StatusCode = StatusCodes.Status200OK
            };
        }
    }
}
