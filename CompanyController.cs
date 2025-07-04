using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositary.Services;

namespace Fertilizer.WebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly CompanyService _service = new();

        [HttpGet]
        public IActionResult GetAllCompanies() => Ok(_service.GetAllCompanies());

        [HttpGet("{id}")]
        public IActionResult GetCompanyById(int id) => Ok(_service.GetCompanyById(id));

        [HttpPost]
        public IActionResult AddCompany([FromBody] FertilizerCompany company)
        {
            _service.AddCompany(company);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCompany([FromBody] FertilizerCompany company)
        {
            _service.UpdateCompany(company);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCompany(int id)
        {
            _service.DeleteCompany(id);
            return Ok();
        }
    }
}

