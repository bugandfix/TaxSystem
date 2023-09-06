using Microsoft.AspNetCore.Mvc;
using Shared.Entities;
using System.Reflection.Metadata.Ecma335;
using TaxSystem.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaxSystem.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaxPayerController : ControllerBase
{
    // GET: api/<TaxPayerController>
    [HttpGet]
    public ActionResult<IEnumerable<Taxpayer>> Get()
    {
        var result= new TaxPayerFakeInMemoryRepository().GetAllTaxPayers();
        return Ok(result);
    }

    // GET api/<TaxPayerController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<TaxPayerController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<TaxPayerController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<TaxPayerController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
