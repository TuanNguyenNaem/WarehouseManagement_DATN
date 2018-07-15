using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;

namespace Service
{
    public class OrderDetailService : IOrderDetailService
    {
        IOrderDetailRepository oder = new OrderDetailRepository();
        public int Add(OrderDetail obj)
        {
            return oder.Add(obj);
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteByTwoId(int orderId, int productId)
        {
            return oder.DeleteByTwoId(orderId, productId);
        }

        public List<OrderDetail> GetAll()
        {
            return oder.GetAll();
        }

        public OrderDetail GetById(int id)
        {
            throw new NotImplementedException();
        }

        public OrderDetail GetByTwoId(int orderId, int productId)
        {
            return oder.GetByTwoId(orderId, productId);
        }

        public bool Update(OrderDetail obj)
        {
            return oder.Update(obj);
        }
    }
}
