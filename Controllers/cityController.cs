using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using webApi.Models;

namespace webApi.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class cityController : ControllerBase  //inherite controllerbase
    {
        public cityController()
        {
        }

        [HttpGet("")]
        public IEnumerable<string> Getstrings() //iterable
        {
            return new string[] {"Atlanta","Albama","Austin", "Boston", "Chicago" }; // cities
        }
    }
}