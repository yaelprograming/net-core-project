using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Core.Entites
{
    public class ParkingLot
    {
        public uint ParkingLotId { get; set; }//מזהה חניון
        public String ParkingLotAdress { get; set; }//כתובת חניון
        [Column(TypeName="decimal(18,4)")]
        public decimal CostForDay { get; set; }//מחיר ליום
        [Column(TypeName = "decimal(18,4)")]
        public decimal CostForHour { get; set; }//מחיר לשעה
        public bool EmptyOrFull { get; set; }//מלא או ריק-יש מקום
        public string Owner { get; set; }  //בעלים
        public uint AmountParkingSpot { get; set; }//מספר מקומות חניה? אולי מספיק המערך
       // public List<ParkingSpot> ParkingSpots { get; set; }

    }
}
