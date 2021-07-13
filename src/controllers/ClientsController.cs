using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace apiCSharp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientsController : ControllerBase
    {

        [HttpGet, Route("/clients")]
        public string Get()
        {
            return "clients";
        }
        [HttpPost, Route("/clients")]
        public string Post()
        {   
            return "clients";
        }
        [HttpPut, Route("/clients")]
        public string Put()
        {   
            return "clients";
        }
        [HttpDelete, Route("/clients")]
        public string Delete()
        {   
            return "clients";
        }
    }
}
