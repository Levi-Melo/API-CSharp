using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using repository;

namespace apiCSharp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressesController : ControllerBase
    {

        [HttpGet, Route("/addresses")]
        public List<Address> Get()
        {
            AddressRepository repo = new AddressRepository();
            return repo.findAll();
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
