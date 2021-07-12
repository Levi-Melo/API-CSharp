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
    public class AddressesController : ControllerBase
    {

        [HttpGet, Route("/addresses")]
        public string Get()
        {
            return "addresses";
        }
        [HttpPost, Route("/addresses")]
        public string Post()
        {   
            return "addresses";
        }
        [HttpPut, Route("/addresses")]
        public string Put()
        {   
            return "addresses";
        }
        [HttpDelete, Route("/addresses")]
        public string Delete()
        {   
            return "addresses";
        }
    }
}
