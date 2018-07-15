using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class OrderService : IService<Order>
    {
        IRepository<Order> emp = new OrderRepository();
        public int Add(Order obj)
        {
            return emp.Add(obj);
        }

        public bool Delete(int id)
        {
            return emp.Delete(id);
        }

        public List<Order> GetAll()
        {
            return emp.GetAll();
        }

        public Order GetById(int id)
        {
            return emp.GetById(id);
        }

        public bool Update(Order obj)
        {
            return emp.Update(obj);
        }
    }
}
