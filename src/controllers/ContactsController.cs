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
        public IActionResult Get()
        {
            ContactRepository repo = new ContactRepository();
            return Ok(repo.findAll());
        }
        [HttpPost, Route("/contacts")]
        public IActionResult Post(Contact data)
        {   
            if (ModelState.IsValid) 
            {
                ContactRepository repo = new ContactRepository();
                repo.insert(data);
                return Ok(data);
            }
            return BadRequest();
        }
        [HttpPut, Route("/contacts/{id}")]
        public IActionResult Put(Guid id, Contact data)
        {   
            ContactRepository repo = new ContactRepository();
            Contact exists = repo.findById(id);
            if(exists == null){
                return BadRequest();
            }
            if (ModelState.IsValid) 
            {
                repo.update(data); 
                return Ok();
            }        
            return BadRequest();
        }
        [HttpDelete, Route("/contacts/{id}")]
        public IActionResult Delete(Guid id)
        {   
            ContactRepository repo = new ContactRepository();
            if(repo.delete(id)){
                return Ok();
            }
            return BadRequest();
        }
    }
}
