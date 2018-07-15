using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        WarehouseDbContext db = new WarehouseDbContext();
        public int Add(OrderDetail obj)
        {
            db.OrderDetails.Add(obj);
            return db.SaveChanges();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteByTwoId(int orderId, int productId)
        {
            var user = GetByTwoId(orderId, productId);
            db.OrderDetails.Remove(user);
            return db.SaveChanges() > 0;
        }

        public List<OrderDetail> GetAll()
        {

            return db.OrderDetails.ToList();
        }

        public OrderDetail GetById(int id)
        {
            throw new NotImplementedException();
        }

        public OrderDetail GetByTwoId(int orderId, int productId)
        {
            return db.OrderDetails.FirstOrDefault(c => c.OrderID == orderId && c.ProductID == productId);
        }

        public bool Update(OrderDetail obj)
        {
            var user = GetByTwoId(obj.OrderID, obj.ProductID);
            user.Quantity = obj.Quantity;
            user.Notes = obj.Notes;
            return db.SaveChanges() > 0;
        }
    }
}
