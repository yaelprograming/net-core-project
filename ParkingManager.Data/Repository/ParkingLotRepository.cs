using ParkingManager.Core.Entites;
using ParkingManager.Core.iRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Data.Repository
{
    public class ParkingLotRepository : IRepository<ParkingLot>
    {
        private readonly DataContext _dataContext;
        public ParkingLotRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<ParkingLot> GetAllDB() { 
        return _dataContext.ParkingLots.ToList();
        }

        public ParkingLot GetByIdDB(int id) {
            return _dataContext.ParkingLots.Where(p => p.ParkingLotId == id).FirstOrDefault();
        }
        public bool AddDB(ParkingLot parkingLot)
        {
            try
            {
                _dataContext.ParkingLots.Add(parkingLot);
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
                ParkingLot parkingLot = _dataContext.ParkingLots.ToList().Find(p => p.ParkingLotId == id);
                _dataContext.ParkingLots.Remove(parkingLot);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

       
        public bool UpdateDB(int id, ParkingLot parkingLot)
        {
            try
            {
                int index = _dataContext.ParkingLots.ToList().FindIndex(p => p.ParkingLotId == id);
                _dataContext.ParkingLots.ToList()[index] = parkingLot;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
