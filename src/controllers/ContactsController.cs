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
    public class ContactsController : ControllerBase
    {

        [HttpGet, Route("/contacts")]
        public List<Contact> Get()
        {
            ContactRepository repo = new ContactRepository();
            return repo.findAll();
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
