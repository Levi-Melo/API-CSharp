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
        public IActionResult Get()
        {
            ClientRepository repo = new ClientRepository();
            return Ok(repo.findAll());
        }
        [HttpPost, Route("/clients")]
        public IActionResult Post(Client data)
        {   
            ClientRepository repo = new ClientRepository();
            if (ModelState.IsValid) 
            {
                repo.insert(data);
                return Ok(data);
            }
            return BadRequest();
        }
        [HttpPut, Route("/clients")]
        public IActionResult Put(Guid id, Client data)
        {   
            ClientRepository repo = new ClientRepository();
            Client exists = repo.findById(id);
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
        [HttpDelete, Route("/clients/{id}")]
        public IActionResult Delete(Guid id)
        {   
            ClientRepository repo = new ClientRepository();
            if(repo.delete(id)){
                return Ok();
            }
            return BadRequest();
        }
    }
}
