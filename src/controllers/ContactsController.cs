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
    public class ContactsController : ControllerBase
    {

        [HttpGet, Route("/contacts")]
        public string Get()
        {
            return "contacts";
        }
        [HttpPost, Route("/contacts")]
        public string Post()
        {   
            return "contacts";
        }
        [HttpPut, Route("/contacts")]
        public string Put()
        {   
            return "contacts";
        }
        [HttpDelete, Route("/contacts")]
        public string Delete()
        {   
            return "contacts";
        }
    }
}
