using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Webapi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            var name = HttpContext.Session.GetString("name").ToString();
            var age = HttpContext.Session.GetInt32("age");

            return name + "   " + age;
        }
    }
}
