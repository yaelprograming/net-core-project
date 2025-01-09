using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Core.Entites
{
    public class Customer
    {
        public uint CustomerId { get; set; }
        public string Tz { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string Email { get; set; }
        public string? CarType { get; set; }  //enum or class
        public bool? Electric { get; set; }
        public string? LicensePlate { get; set; }
        //שדה חישובי של מספר שעות חניה בחודש האחרון
        //public List<Payment>Payments { get; set; }
        //public List<Reservation> Reservations { get; set; }
       



    }
}
