using EFTutorial.Data;
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
}
}