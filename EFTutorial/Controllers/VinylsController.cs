using EFTutorial.Data;
using EFTutorial.Dtos;
using EFTutorial.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EFTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    
    public class VinylsController : ControllerBase
    {
        private readonly IVinylsRepository _repository;

        public VinylsController(IVinylsRepository repository)
        {
            _repository = repository;
        }
    
    [HttpGet]

    public IEnumerable<Vinyl> GetVinyls()
    {
        return _repository.GetVinyls();
    }

        [HttpGet("{id}")]

        public ActionResult<Vinyl> GetVinyl(int id)
        {
            var vinyl = _repository.GetVinyl(id);

            if(vinyl == null)
                return NotFound();

            return Ok(vinyl);
        }

        [HttpPost]
        public ActionResult AddVinyl(Vinyl v)
        {
          

            bool res = _repository.AddVinyl(v);
            if(!res)
                return BadRequest();
            return CreatedAtAction(nameof(AddVinyl), v);
        }
        [HttpPut("{id}")]

        public ActionResult UpdateItem(Vinyl v, int id)
        {
            var existingVinyl = _repository.GetVinyl(id);

            if (existingVinyl == null)
                return NotFound();

            existingVinyl.Title = v.Title;
            bool res = _repository.UpdateVinyl(existingVinyl);
            if (!res)
                return BadRequest();
            return Ok();
        }
        [HttpDelete("{id}")]

        public ActionResult DeleteVinyl(int id)
        {
            var vinyl = GetVinyl(id);
            if (vinyl == null)
                return NotFound();

            bool res = _repository.DeleteVinyl(id);

            if (!res)
                return BadRequest();

            return NoContent();
        }
    }
}