using ParkingManager.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Core.iService
{
    public interface IParkingLotService
    {
        public List<ParkingLot> GetParkingLots();
        public ParkingLot GetParkingLotById(int id);
        public bool AddParkingLot(ParkingLot parkingLot);
        public bool UpdateParkingLot(int id, ParkingLot parkingLot);
        public bool DeleteParkingLot(int id);

    }
}
