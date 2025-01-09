using ParkingManager.Core.Entites;
using ParkingManager.Core.iRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Data.Repository
{
    public class ReservationRepository : IRepository<Reservation>
    {
        private readonly DataContext _dataContext;
        public ReservationRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Reservation> GetAllDB()
        {
            return _dataContext.Reservations.ToList();
        }

        public Reservation GetByIdDB(int id)
        {
            return _dataContext.Reservations.Where(r => r.ReservationId == id).FirstOrDefault();
        }
        public bool AddDB(Reservation reservation)
        {
            try
            {
                _dataContext.Reservations.Add(reservation);
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
                Reservation reservation = _dataContext.Reservations.ToList().Find(p => p.ReservationId == id);
                _dataContext.Reservations.Remove(reservation);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool UpdateDB(int id, Reservation reservation)
        {
            try
            {
                int index = _dataContext.Reservations.ToList().FindIndex(p => p.ReservationId == id);
                _dataContext.Reservations.ToList()[index] = reservation;
                ;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
