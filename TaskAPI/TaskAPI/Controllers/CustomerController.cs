using Microsoft.AspNetCore.Mvc;
using TaskAPI.Iservice;
using TaskAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private Icustomerservice _oCustomerService;

        public CustomerController(Icustomerservice Ocustomerservice) {

            _oCustomerService = Ocustomerservice;
        }
        // GET: api/<CustomerController>
       /* [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomerController>
        [HttpPost]
        public Customer Post([FromBody] Customer oCustomer)
        {
            if (ModelState.IsValid) return _oCustomerService.insert(oCustomer);
            return null;
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
