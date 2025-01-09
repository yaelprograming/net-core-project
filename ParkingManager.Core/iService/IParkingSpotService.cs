using ParkingManager.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Core.iService
{
    public interface IParkingSpotService
    {
        public List<ParkingSpot> GetParkingSpots();
        public ParkingSpot GetParkingSpotById(int id);
        public bool AddParkingSpot(ParkingSpot parkingLot);
        public bool UpdateParkingSpot(int id, ParkingSpot parkingSpot);
        public bool DeleteParkingSpot(int id);

    }
}
