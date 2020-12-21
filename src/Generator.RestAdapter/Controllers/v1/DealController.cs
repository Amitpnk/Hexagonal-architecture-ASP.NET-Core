using Generator.DomainApi.Port;
using Generator.Persistence.Adapter.Port;
using Microsoft.AspNetCore.Mvc;

namespace Generator.RestAdapter.Controllers.v1
{
    [ApiController]
    //[Route("api/v{version:apiVersion}/[controller]")]
    [Route("api/v1/deal")]
    public class DealController : ControllerBase
    {
        private readonly IObtainDeal<int> _obtainDeal;

        public DealController(IObtainDeal<int> obtainDeal)
        {
            _obtainDeal = obtainDeal;
        }

        // GET: api/deal
        [HttpGet]
        public IActionResult Get()
        {
            var result = _obtainDeal.GetDeals();
            return Ok(result);
        }

        // GET: api/deal/1
        [HttpGet]
        [Route("{id}", Name = "GetDeal")]
        public IActionResult Get(int id)
        {
            var result = _obtainDeal.GetDeal(id);
            return Ok(result);
        }
    }
}
