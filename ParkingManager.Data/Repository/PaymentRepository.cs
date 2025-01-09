//using Microsoft.EntityFrameworkCore;
using ParkingManager.Core.Entites;
using ParkingManager.Core.iRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Data.Repository
{
    public class PaymentRepository : IRepository<Payment>
    {
        private readonly DataContext _dataContext;
        public PaymentRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Payment> GetAllDB()
        {
            return _dataContext.Payments.ToList();
        }

        public Payment GetByIdDB(int id)
        {
            return _dataContext.Payments.Where(p => p.PaymentId == id).FirstOrDefault();
        }
        public bool AddDB(Payment payment)
        {
            try
            {
                _dataContext.Payments.Add(payment);
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
                Payment payment = _dataContext.Payments.ToList().Find(p => p.PaymentId == id);
                _dataContext.Payments.Remove(payment);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateDB(int id, Payment payment)
        {
            try
            {
                int index = _dataContext.Payments.ToList().FindIndex(p => p.PaymentId == id);
                _dataContext.Payments.ToList()[index] = payment;
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
