using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class OutWarehouseService : IService<OutWarehouse>
    {
        IRepository<OutWarehouse> emp = new OutWarehouseRepository();
        public int Add(OutWarehouse obj)
        {
            return emp.Add(obj);
        }

        public bool Delete(int id)
        {
            return emp.Delete(id);
        }

        public List<OutWarehouse> GetAll()
        {
            return emp.GetAll();
        }

        public OutWarehouse GetById(int id)
        {
            return emp.GetById(id);
        }

        public bool Update(OutWarehouse obj)
        {
            return emp.Update(obj);
        }
    }
}
