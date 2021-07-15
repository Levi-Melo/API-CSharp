using entities;
using Microsoft.AspNetCore.Mvc;
using repository;
using System;
using System.Collections.Specialized;
namespace apiCSharp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressesController : ControllerBase
    {

        [HttpGet, Route("/addresses")]
        public IActionResult Get()
        {
            AddressRepository repo = new AddressRepository();
            return Ok(repo.findAll());
        }
        [HttpPost, Route("/addresses")]
        public IActionResult Post( Address data)
        {   
            AddressRepository repo = new AddressRepository();
            if (ModelState.IsValid) 
            {
                repo.insert(data);
                return Ok(data);
            }
            return BadRequest();
        }
        [HttpPut, Route("/addresses/{id}")]
        public IActionResult Put(Guid id, Address data)
        {   
            AddressRepository repo = new AddressRepository();
            Address exists = repo.findById(id);
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
        [HttpDelete, Route("/addresses/{id}")]
        public IActionResult Delete(Guid id)
        {   
            AddressRepository repo = new AddressRepository();
            if(repo.delete(id)){
                return Ok();
            }
            return BadRequest();
        }
    }
}
