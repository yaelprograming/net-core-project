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
    public class CustomerService: ICustomerService
    {
        readonly IRepository<Customer> _customerService;
        public CustomerService(IRepository<Customer> customerService)
        {
            _customerService = customerService;
        }
        public List<Customer> GetCustomers()
        {
            return _customerService.GetAllDB();
        }

        public Customer GetCustomerById(int id)
        {
            var data = _customerService.GetAllDB();
            if (data == null || (data.FindIndex(c => c.CustomerId == id) == -1))
                return null;
            return _customerService.GetByIdDB(id);
        }

        public bool AddCustomer(Customer customer)
        {
            var data = _customerService.GetAllDB();
            if (data == null || (data.Find(b => b.CustomerId == customer.CustomerId) != null))//אם ה id כבר קיים במערכת
                return false;
            if (!ValidationCheck.IsEmailValid(customer.Email) && !ValidationCheck.IsTzValid(customer.Tz))
                return false;
            return _customerService.AddDB(customer);

        }

        public bool UpdateCustomer(int id, Customer customer)
        {
            var data = _customerService.GetAllDB();
            if (data == null || (data.Find(c => c.CustomerId == id) == null))
                return false;
            return _customerService.UpdateDB(id, customer);
        }

        public bool DeleteCustomer(int id)
        {
            var data = _customerService.GetAllDB();
            if (data == null || (data.Find(c => c.CustomerId == id) == null))
                return false;
            return _customerService.DeleteDB(id);
        }
    }
}