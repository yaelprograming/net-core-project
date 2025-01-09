using Microsoft.AspNetCore.Mvc;
using ParkingManager.Core.Entites;
using ParkingManager.Core.iService;
using ParkingManager.Service.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ParkingManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        readonly ICustomerService _customerServies;
        public CustomerController(ICustomerService customerServies)
        {
            _customerServies = customerServies;
        }
        // GET: api/<CustomersController>
        [HttpGet]
        public ActionResult<List<Customer>> Get()
        {
            return _customerServies.GetCustomers();
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
             if(id< 0)
                return BadRequest();
            var customer = _customerServies.GetCustomerById(id);
            if (customer == null)
                return NotFound();
            return customer;
        }

        // POST api/<CustomersController>
        [HttpPost]
        public ActionResult Post([FromBody] Customer value)
        {
            bool isSuccess=_customerServies.AddCustomer(value);
            if (isSuccess)
                return Ok(true);
            return BadRequest("ID exists in the system or the file donwt found");
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Customer value)
        {
            bool isSuccess = _customerServies.UpdateCustomer(id, value);
            if (isSuccess)
                return Ok(true);
            return NotFound();
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool isSuccess =_customerServies.DeleteCustomer(id);
            if (isSuccess)
                return Ok(true);
            return NotFound();
        }
    }
}
