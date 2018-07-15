using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IOrderDetailService : IService<OrderDetail>
    {
        OrderDetail GetByTwoId(int orderId, int productId);
        bool DeleteByTwoId(int orderId, int productId);
    }
}
