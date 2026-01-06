using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mynewapi.obj
{
    [ApiController]
    [Route("api/[controller]")]
    public class SayHello : ControllerBase
    {
       
        [HttpGet]
        public string Greeting(string name)
        {
            return $"Salutations, {name}";
        }
            
        

    }
}
