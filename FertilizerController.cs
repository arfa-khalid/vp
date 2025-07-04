using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositary.Services;

namespace Fertilizer.WebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class FertilizerController : ControllerBase
    {
        private readonly FertilizerService _service = new();

        [HttpGet]
        public IActionResult GetAllFertilizers() => Ok(_service.GetAllFertilizers());

        [HttpGet("{id}")]
        public IActionResult GetFertilizerById(int id) => Ok(_service.GetFertilizerById(id));

        [HttpPost]
        public IActionResult AddFertilizer([FromBody] DAL.Entities.Fertilizer f)
        {
            _service.AddFertilizer(f);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateFertilizer([FromBody] DAL.Entities.Fertilizer f)
        {
            _service.UpdateFertilizer(f);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFertilizer(int id)
        {
            _service.DeleteFertilizer(id);
            return Ok();
        }
    }
}

