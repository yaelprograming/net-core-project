using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Core.Entites
{
    public class ParkingSpot
    {
        public uint ParkingSpotId { get; set; }

        public uint ParkingLotId { get; set; }
        [ForeignKey(nameof(ParkingLotId))]
        public ParkingLot ParkingLot { get; set; }
        //   public decimal Price { get; set; }
        public bool Available { get; set; }
    }
}
