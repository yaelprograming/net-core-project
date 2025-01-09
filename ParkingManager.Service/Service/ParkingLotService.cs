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
    public class ParkingLotService: IParkingLotService
    {
        readonly IRepository<ParkingLot> _parkingLotService;
        public ParkingLotService(IRepository<ParkingLot> parkingLotService)
        {
            _parkingLotService = parkingLotService;
        }
        public List<ParkingLot> GetParkingLots()
        {
            return _parkingLotService.GetAllDB();
        }

        public ParkingLot GetParkingLotById(int id)
        {
            var data = _parkingLotService.GetAllDB();
            if (data == null || (data.FindIndex(p => p.ParkingLotId == id) == -1))
                return null;
            return _parkingLotService.GetByIdDB(id);
        }

        public bool AddParkingLot(ParkingLot parkingLot)
        {
            var data = _parkingLotService.GetAllDB();
            if (data == null || (data.Find(b => b.ParkingLotId == parkingLot.ParkingLotId) != null))//אם ה id כבר קיים במערכת
                return false;
            return _parkingLotService.AddDB(parkingLot);

        }

        public bool UpdateParkingLot(int id, ParkingLot parkingLot)
        {
            var data = _parkingLotService.GetAllDB();
            if (data == null || (data.Find(p => p.ParkingLotId == id) == null))
                return false;
            return _parkingLotService.UpdateDB(id, parkingLot);
        }

        public bool DeleteParkingLot(int id)
        {
            var data = _parkingLotService.GetAllDB();
            if (data == null || (data.Find(p => p.ParkingLotId == id) == null))
                return false;
            return _parkingLotService.DeleteDB(id);
        }
    }
}
