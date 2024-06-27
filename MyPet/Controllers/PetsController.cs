using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyPet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Pets()
        {
            var pets = new string[] { "Pet 1", "Pet 2", "Pet 3" };
            return Ok(pets);
        }

        [HttpPost]
        public IActionResult NewPet() 
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdatePet()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeletePet()
        {
            var SomethingWentWrong = true;
            if (SomethingWentWrong)
                return BadRequest();
            return Ok();
        }
    }
}
