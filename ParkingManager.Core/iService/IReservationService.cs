using ParkingManager.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Core.iService
{
    public interface IReservationService
    {
        List<Reservation> GetReservations();
        Reservation GetReservationById(int id);
        bool AddReservation(Reservation Reservation);
        bool DeleteReservation(int id);
        bool UpdateReservation(int id, Reservation Reservation);
    }
}
