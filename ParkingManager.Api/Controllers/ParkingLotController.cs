using Microsoft.AspNetCore.Mvc;
using ParkingManager.Core.Entites;
using ParkingManager.Core.iService;
using ParkingManager.Service.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ParkingManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingLotController : ControllerBase
    {
        readonly IParkingLotService _parkingLotService;
        public ParkingLotController(IParkingLotService parkingLotService)
        {
            _parkingLotService = parkingLotService;
        }
        // GET: api/<ParkingController>
        [HttpGet]
        public ActionResult<List<ParkingLot>> Get()
        {
            return _parkingLotService.GetParkingLots();
        }

        // GET api/<ParkingController>/5
        [HttpGet("{id}")]
        public ActionResult<ParkingLot> GetById(int id)
        {
            if (id < 0)
                return BadRequest();
            var parkingLot = _parkingLotService.GetParkingLotById(id);
            if (parkingLot == null)
                return NotFound();
            return parkingLot;
        }

        // POST api/<ParkingController>
        [HttpPost]
        public ActionResult Post([FromBody] ParkingLot value)
        {
            bool isSuccess =_parkingLotService.AddParkingLot(value);
            if (isSuccess)
                return Ok(true);
            return BadRequest("ID exists in the system or the file donwt found");
        }

        // PUT api/<ParkingController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ParkingLot value)
        {
            bool isSuccess = _parkingLotService.UpdateParkingLot(id, value);
            if (isSuccess)
                return Ok(true);
            return NotFound();
        }

        // DELETE api/<ParkingController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            bool isSuccess =_parkingLotService.DeleteParkingLot(id);
            if (isSuccess)
                return Ok(true);
            return NotFound();
        }

    }
}
