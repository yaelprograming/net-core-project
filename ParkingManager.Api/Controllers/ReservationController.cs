using Microsoft.AspNetCore.Mvc;
using ParkingManager.Core.Entites;
using ParkingManager.Core.iService;
using ParkingManager.Service.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ParkingManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        readonly IReservationService _ReservationService;
        public ReservationController(IReservationService reservationService)
        {
            _ReservationService = reservationService;
        }
        // GET: api/<OrdersController>
        [HttpGet]
        public ActionResult<IEnumerable<Reservation>> Get()
        {
            return _ReservationService.GetReservations();
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public ActionResult<Reservation> GetById(int id)
        {
            if (id < 0)
                return BadRequest();
            var reservation = _ReservationService.GetReservationById(id);
            if (reservation == null)
                return NotFound();
            return reservation;
        }

        // POST api/<OrdersController>
        [HttpPost]
        public ActionResult Post([FromBody] Reservation value)
        {
            bool isSuccess =_ReservationService.AddReservation(value);
            if (isSuccess)
                return Ok(true);
            return BadRequest("ID exists in the system or the file donwt found");
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Reservation value)
        {
            bool isSuccess =_ReservationService.UpdateReservation(id, value);
            if (isSuccess)
                return Ok(true);
            return NotFound();
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool isSuccess = _ReservationService.DeleteReservation(id);
            if (isSuccess)
                return Ok(true);
            return NotFound();
        }
    }
}
