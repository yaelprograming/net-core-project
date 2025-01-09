using Microsoft.AspNetCore.Mvc;
using ParkingManager.Core.Entites;
using ParkingManager.Core.iService;
using ParkingManager.Service.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ParkingManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        readonly IPaymentService _paymentService;
        public PaymentController()
        {
            
        }
        // GET: api/<PaymentController>
        [HttpGet]
        public ActionResult<List<Payment>> Get()
        {
            return _paymentService.GetPayments();
        }

        // GET api/<PaymentController>/5
        [HttpGet("{id}")]
        public ActionResult<Payment> GetById(int id)
        {
            if (id < 0)
                return BadRequest();
            var payment = _paymentService.GetPaymentById(id);
            if (payment == null)
                return NotFound();
            return payment;
        }

        // POST api/<PaymentController>
        [HttpPost]
        public ActionResult Post([FromBody] Payment value)
        {
            bool isSuccess = _paymentService.AddPayment(value);
            if (isSuccess)
                return Ok(true);
            return BadRequest("ID exists in the system or the file donwt found");
        }

        // PUT api/<PaymentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Payment value)
        {
            bool isSuccess =_paymentService.UpdatePayment(id, value);
            if (isSuccess)
                return Ok(true);
            return NotFound();
        }

        // DELETE api/<PaymentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool isSuccess = _paymentService.DeletePayment(id);
            if (isSuccess)
                return Ok(true);
            return NotFound();
        }
    }
}
