using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RWKBlazor.Shared.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RWKBlazor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ValuesController : ControllerBase
    {
        private readonly IValueService _valueService;

        public ValuesController(IValueService valueService)
        {
            _valueService = valueService;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public Task<IEnumerable<string>> Get()
        {
            return _valueService.GetValuesAsync();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
