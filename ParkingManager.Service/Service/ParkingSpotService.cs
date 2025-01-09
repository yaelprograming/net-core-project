using ParkingManager.Core.Entites;
using ParkingManager.Core.iRepository;
using ParkingManager.Core.iService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Service.Service
{
    public class ParkingSpotService: IParkingSpotService
    {
        readonly IRepository<ParkingSpot> _parkingSpotService;
        public ParkingSpotService(IRepository<ParkingSpot> parkingSpotService)
        {
            _parkingSpotService = parkingSpotService;
        }
        public List<ParkingSpot> GetParkingSpots()
        {
            return _parkingSpotService.GetAllDB();
        }

        public ParkingSpot GetParkingSpotById(int id)
        {
            var data = _parkingSpotService.GetAllDB();
            if (data == null || (data.FindIndex(p => p.ParkingSpotId == id) == -1))
                return null;
            return _parkingSpotService.GetByIdDB(id);
        }

        public bool AddParkingSpot(ParkingSpot parkingSpot)
        {
            var data = _parkingSpotService.GetAllDB();
            if (data == null || (data.Find(b => b.ParkingSpotId == parkingSpot.ParkingSpotId) != null))//אם ה id כבר קיים במערכת
                return false;
            return _parkingSpotService.AddDB(parkingSpot);

        }

        public bool UpdateParkingSpot(int id, ParkingSpot parkingSpot)
        {
            var data = _parkingSpotService.GetAllDB();
            if (data == null || (data.Find(p => p.ParkingSpotId == id) == null))
                return false;
            return _parkingSpotService.UpdateDB(id, parkingSpot);
        }

        public bool DeleteParkingSpot(int id)
        {
            var data = _parkingSpotService.GetAllDB();
            if (data == null || (data.Find(p => p.ParkingSpotId == id) == null))
                return false;
            return _parkingSpotService.DeleteDB(id);
        }
    }
}
