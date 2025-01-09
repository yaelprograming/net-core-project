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
    public class ReservationService : IReservationService
    {
        readonly IRepository<Reservation> _reservationService;
        public ReservationService(IRepository<Reservation> reservationService)
        {
            _reservationService = reservationService;
        }
        public List<Reservation> GetReservations()
        {
            return _reservationService.GetAllDB();
        }

        public Reservation GetReservationById(int id)
        {
            var data = _reservationService.GetAllDB();
            if (data == null || (data.FindIndex(p => p.ReservationId == id) == -1))
                return null;
            return _reservationService.GetByIdDB(id);
        }

        public bool AddReservation(Reservation reservation)
        {
            var data = _reservationService.GetAllDB();
            if (data == null || (data.Find(b => b.ReservationId == reservation.ReservationId) != null))//אם ה id כבר קיים במערכת
                return false;
            return _reservationService.AddDB(reservation);

        }

        public bool UpdateReservation(int id, Reservation reservation)
        {
            var data = _reservationService.GetAllDB();
            if (data == null || (data.Find(p => p.ReservationId == id) == null))
                return false;
            return _reservationService.UpdateDB(id, reservation);
        }

        public bool DeleteReservation(int id)
        {
            var data = _reservationService.GetAllDB();
            if (data == null || (data.Find(p => p.ReservationId == id) == null))
                return false;
            return _reservationService.DeleteDB(id);
        }
    }
}
