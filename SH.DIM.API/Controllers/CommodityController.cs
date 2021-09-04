using Microsoft.AspNetCore.Mvc;
using SH.DIM.DataAccess.Entities;
using SH.DIM.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SH.DIM.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CommodityController : ControllerBase
{
    private readonly ICommodityService commodityService;

    public CommodityController(ICommodityService commodityService)
    {
        this.commodityService = commodityService;
    }
    // GET: api/<CommodityController>
    [HttpGet]
    public IEnumerable<Commodity> Get()
    {
        return commodityService.GetCommodities();
    }

    // GET api/<CommodityController>/5
    [HttpGet("{id}")]
    public Commodity Get(string id)
    {
        return commodityService.GetCommodities().ToList().Find(c => c.Id == id);
    }

    // POST api/<CommodityController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<CommodityController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<CommodityController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
