using ParkingManager.Core.Entites;
using ParkingManager.Core.iRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManager.Data.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
         readonly DataContext _dataContext;
        public CustomerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public bool AddDB(Customer customer)
        {
            try
            {
                _dataContext.Customers.Add(customer);
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
                Customer customer = _dataContext.Customers.ToList().Find(b => b.CustomerId == id);
                _dataContext.Customers.Remove(customer);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Customer> GetAllDB()
        {
            return _dataContext.Customers.ToList();
        }

        public Customer GetByIdDB(int id)
        {
            return _dataContext.Customers.Where(c => c.CustomerId == id).FirstOrDefault();
        }

        public bool UpdateDB(int id, Customer customer)
        {
            try
            {
                int index = _dataContext.Customers.ToList().FindIndex(b => b.CustomerId == id);
                _dataContext.Customers.ToList()[index] = customer;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
