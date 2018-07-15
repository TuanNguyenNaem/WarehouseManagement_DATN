using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class OrderRepository : IRepository<Order>
    {
        WarehouseDbContext db = new WarehouseDbContext();
        public int Add(Order obj)
        {
            db.Orders.Add(obj);
            return db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var user = GetById(id);
            db.Orders.Remove(user);
            return db.SaveChanges() > 0;
        }

        public List<Order> GetAll()
        {

            return db.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return db.Orders.FirstOrDefault(c => c.OrderID == id);
        }

        public bool Update(Order obj)
        {
            var user = GetById(obj.OrderID);
            user.EmployeeID = obj.EmployeeID;
            user.CustomerID = obj.CustomerID;
            user.CreateDate = obj.CreateDate;
            user.Status = obj.Status;
            user.Notes = obj.Notes;
            return db.SaveChanges() > 0;
        }
    }
}
