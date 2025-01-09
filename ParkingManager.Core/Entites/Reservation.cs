using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Core.Entites
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        //מספיק המיקום בחניה שיורש חניון
        //public uint ParkingId { get; set; }
        //[ForeignKey(nameof(ParkingId))]
        //public ParkingLot Parking { get; set; }
       
        public uint CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; }

        public DateTime DateReservation { get; set; }

        public uint ParkingPlaceId { get; set; }
        [ForeignKey(nameof(ParkingPlaceId))]
        public ParkingSpot ParkingPlace { get; set; }
        public uint ParkingHours { get; set; }
        public uint DepartureTime { get; set; }

        public uint PaymentId { get; set; }
        [ForeignKey(nameof(PaymentId))]
        public Payment Payment { get; set; }
    }
}
