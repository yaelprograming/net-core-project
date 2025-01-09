using ParkingManager.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Core.iService
{
    public interface ICustomerService
    {
        public List<Customer> GetCustomers();
        public Customer GetCustomerById(int id);
        public bool AddCustomer(Customer customer);
        public bool UpdateCustomer(int id, Customer customer);
        public bool DeleteCustomer(int id);

    }
}
