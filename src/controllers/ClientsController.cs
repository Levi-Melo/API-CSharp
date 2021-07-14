using System;
using System.Collections.Generic;
using System.IO;
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
    public class ClientsController : ControllerBase
    {

        [HttpGet, Route("/clients")]
        public List<Client> Get()
        {
            ClientRepository repo = new ClientRepository();
            return repo.findAll();
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
