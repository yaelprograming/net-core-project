using Microsoft.AspNetCore.Mvc;
using ParkingManager.Core.Entites;
using ParkingManager.Core.iService;
using ParkingManager.Service.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ParkingManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingSpotController : ControllerBase
    {
        readonly IParkingSpotService _parkingSpotService;
        public ParkingSpotController(IParkingSpotService parkingSpotService)
        {
            _parkingSpotService = parkingSpotService;
        }
        // GET: api/<ParkingSpotController>
        [HttpGet]
        public ActionResult<List<ParkingSpot>> Get()
        {
            return _parkingSpotService.GetParkingSpots();
        }


        // GET api/<ParkingSpotController>/5
        [HttpGet("{id}")]
        public ActionResult<ParkingSpot> GetById(int id)
        {
            if (id < 0)
                return BadRequest();
            var parkingSpot = _parkingSpotService.GetParkingSpotById(id);
            if (parkingSpot == null)
                return NotFound();
            return parkingSpot;
        }

        // POST api/<ParkingSpotController>
        [HttpPost]
        public ActionResult Post([FromBody] ParkingSpot value)
        {
            bool isSuccess = _parkingSpotService.AddParkingSpot(value);
            if (isSuccess)
                return Ok(true);
            return BadRequest("ID exists in the system or the file donwt found");
        }

        // PUT api/<ParkingSpotController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ParkingSpot value)
        {
            bool isSuccess = _parkingSpotService.UpdateParkingSpot(id, value);
            if (isSuccess)
                return Ok(true);
            return NotFound();
        }

        // DELETE api/<ParkingSpotController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool isSuccess = _parkingSpotService.DeleteParkingSpot(id);
            if (isSuccess)
                return Ok(true);
            return NotFound();
        }
    }
}
