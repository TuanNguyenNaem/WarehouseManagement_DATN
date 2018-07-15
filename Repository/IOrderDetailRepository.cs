using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
        OrderDetail GetByTwoId(int orderId, int productId);
        bool DeleteByTwoId(int orderId, int productId);
    }
}
