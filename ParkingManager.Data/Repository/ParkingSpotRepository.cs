using ParkingManager.Core.Entites;
using ParkingManager.Core.iRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Data.Repository
{
    public class ParkingSpotRepository : IRepository<ParkingSpot>
    {
        private readonly DataContext _dataContext;
        public ParkingSpotRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<ParkingSpot> GetAllDB()
        {
            return _dataContext.ParkingSpots.ToList();
        }

        public ParkingSpot GetByIdDB(int id)
        {
            return _dataContext.ParkingSpots.Where(p => p.ParkingSpotId == id).FirstOrDefault();
        }
        public bool AddDB(ParkingSpot parkingSpot)
        {
            try
            {
                _dataContext.ParkingSpots.Add(parkingSpot);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteDB(int id)
        {
            try
            {
                ParkingSpot parkingSpot = _dataContext.ParkingSpots.ToList().Find(p => p.ParkingSpotId == id);
                _dataContext.ParkingSpots.Remove(parkingSpot);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool UpdateDB(int id, ParkingSpot parkingSpot)
        {
            try
            {
                int index = _dataContext.ParkingSpots.ToList().FindIndex(p => p.ParkingSpotId == id);
                _dataContext.ParkingSpots.ToList()[index] = parkingSpot;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
