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
    public class PaymentService : IPaymentService
    {
        readonly IRepository<Payment> _paymentService;
        public PaymentService(IRepository<Payment> paymentService)
        {
           _paymentService = paymentService;
        }
        public List<Payment> GetPayments()
        {
            return _paymentService.GetAllDB();
        }

        public Payment GetPaymentById(int id)
        {
            var data = _paymentService.GetAllDB();
            if (data == null || (data.FindIndex(p => p.PaymentId == id) == -1))
                return null;
            return _paymentService.GetByIdDB(id);
        }

        public bool AddPayment(Payment payment)
        {
            var data = _paymentService.GetAllDB();
            if (data == null || (data.Find(b => b.PaymentId == payment.PaymentId) != null))//אם ה id כבר קיים במערכת
                return false;
            return _paymentService.AddDB(payment);

        }

        public bool UpdatePayment(int id, Payment payment)
        {
            var data = _paymentService.GetAllDB();
            if (data == null || (data.Find(p => p.PaymentId == id) == null))
                return false;
            return _paymentService.UpdateDB(id, payment);
        }

        public bool DeletePayment(int id)
        {
            var data = _paymentService.GetAllDB();
            if (data == null || (data.Find(p => p.PaymentId == id) == null))
                return false;
            return _paymentService.DeleteDB(id);
        }
    }
}
