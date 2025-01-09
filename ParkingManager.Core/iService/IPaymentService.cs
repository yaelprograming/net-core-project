using ParkingManager.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Core.iService
{
    public interface IPaymentService
    {
        public List<Payment> GetPayments();
        public Payment GetPaymentById(int id);
        public bool AddPayment(Payment parkingLot);
        public bool UpdatePayment(int id, Payment payment);
        public bool DeletePayment(int id);

    }
}
