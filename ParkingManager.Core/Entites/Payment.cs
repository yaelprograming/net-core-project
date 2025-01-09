using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Core.Entites
{
    //אפשר בכמה תשלומים
    public enum PaymentMethod
    {
        CreditCard,
        Cash,
        Cheque,
        BankTransfer
    }
    public class Payment
    {
        public uint PaymentId { get; set; }

        //אולי מספיק רק הזמנה?
        //public uint CustomerId { get; set; }
        //[ForeignKey(nameof(CustomerId))]
        //public Customer Customer { get; set; }//מזהה לקוח
        //public uint ParkingId { get; set; }//מזהה חניון
        //[ForeignKey(nameof(ParkingId))]
        //public ParkingLot Parking { get; set; }

        public int ReservationId { get; set; }
        [ForeignKey(nameof(ReservationId))]
        public Reservation Reservation { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal TotalAmount { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal DiscountAmount { get; set; }//סכום הנחה
        public PaymentMethod PaymentMethod { get; set; }   //אמצעי תשלום

    }
}
