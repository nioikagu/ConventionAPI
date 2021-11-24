using Convention.Forms.Convention;
using Convention.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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
            var s = String.Format(result.Description, form.Name, form.Number, DateTime.Now, form.Payment);
            return Ok(s);
        }
    }
}
