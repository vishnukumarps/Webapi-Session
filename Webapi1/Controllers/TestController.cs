using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;

namespace Webapi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IDistributedCache cache;
        public TestController(IDistributedCache cache)
        {
            this.cache = cache;
        }

        [HttpGet]
        [Route("Test2")]
        public  string Test2()
        {
             cache.SetString("name","vishnu");

            //var name = HttpContext.Session.GetString("name").ToString();
            //var age = HttpContext.Session.GetInt32("age");

            return null;
        }

        [HttpGet]
        [Route("Get2")]
        public string Get2()
        {
            var x=cache.GetString("name");

           
            return x;


        }
    }
}
