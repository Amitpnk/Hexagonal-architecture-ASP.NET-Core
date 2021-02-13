using Generator.DomainApi.Port;
using Microsoft.AspNetCore.Mvc;

namespace Generator.RestAdapter.Controllers.v1
{
    [ApiController]
    //[Route("api/v{version:apiVersion}/[controller]")]
    [Route("api/v1/deal")]
    public class DealController : ControllerBase
    {
        private readonly IRequestDeal<int> _requestDeal;

        public DealController(IRequestDeal<int> requestDeal)
        {
            _requestDeal = requestDeal;
        }

        // GET: api/deal
        [HttpGet]
        public IActionResult Get()
        {
            var result = _requestDeal.GetDeals();
            return Ok(result);
        }

        // GET: api/deal/1
        [HttpGet]
        [Route("{id}", Name = "GetDeal")]
        public IActionResult Get(int id)
        {
            var result = _requestDeal.GetDeal(id);
            return Ok(result);
        }
    }
}
