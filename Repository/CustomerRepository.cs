using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        WarehouseDbContext db = new WarehouseDbContext();
        public int Add(Customer obj)
        {
            db.Customers.Add(obj);
            return db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var user = GetById(id);
            db.Customers.Remove(user);
            return db.SaveChanges() > 0;
        }

        public List<Customer> GetAll()
        {

            return db.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return db.Customers.FirstOrDefault(c => c.CustomerID == id);
        }

        public bool Update(Customer obj)
        {
            var user = GetById(obj.CustomerID);
            user.CustomerName = obj.CustomerName;
            user.BirthDate = obj.BirthDate;
            user.Gender = obj.Gender;
            user.Address = obj.Address;
            user.PhoneNumber = obj.PhoneNumber;
            user.AccountNumber = obj.AccountNumber;
            user.TaxCode = obj.TaxCode;
            user.Accumulation = obj.Accumulation;
            user.VIPID = obj.VIPID;
            user.Area = obj.Area;
            user.Email = obj.Email;
            user.Notes = obj.Notes;
            return db.SaveChanges() > 0;
        }
    }
}
