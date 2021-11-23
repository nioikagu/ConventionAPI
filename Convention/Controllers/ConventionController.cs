using Convention.Forms.Convention;
using Convention.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Convention.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConventionController : ControllerBase
    {
        private readonly ConventionRepository conventionRepository;

        public ConventionController(ConventionRepository conventionRepository)
        {
            this.conventionRepository = conventionRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = conventionRepository.Get();
            return Ok(result);
        }

        [HttpPost("generate")]
        public IActionResult Generate(GenerateForm form)
        {
            var result = conventionRepository.Get().FirstOrDefault();
            return Ok(result);
        }
    }
}
