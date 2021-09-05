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
        return commodityService.GetAll();
    }

    // GET api/<CommodityController>
    [HttpGet("{id:length(24)}", Name = "GetCommodity")]
    public ActionResult<Commodity> Get(string id)
    {
        Commodity commodity = commodityService.Get(id);
        if (commodity == null)
        {
            return NotFound();
        }
        else
        {
            return commodity;
        }
    }

    // POST api/<CommodityController>
    [HttpPost]
    public ActionResult<Commodity> Post(Commodity commodity)
    {
        commodityService.Create(commodity);

        return CreatedAtRoute("GetCommodity", new { id = commodity.Id.ToString() }, commodity);
    }

    // PUT api/<CommodityController>/5
    [HttpPut("{id:length(24)}")]
    public IActionResult Put(string id, Commodity commodityIn)
    {
        var commodity = commodityService.Get(id);
        if (commodity == null)
        {
            return NotFound();
        }

        commodityService.Update(id, commodityIn);
        return NoContent();
    }

    // DELETE api/<CommodityController>/5
    [HttpDelete("{id:length(24)}")]
    public IActionResult Delete(string id)
    {
        var commodity = commodityService.Get(id);
        if (commodity == null)
        {
            return NotFound();
        }

        commodityService.Remove(commodity);
        return NoContent();
    }
}
