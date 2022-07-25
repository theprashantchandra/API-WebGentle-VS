
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ConsoleToWebAPI.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class TestController : ControllerBase
    {
        public string Get()
        {
            return "Hello from get";
        }
        public string Get1()
        {
            return "Hello from get";
        }
    }
}
