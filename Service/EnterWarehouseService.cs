using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class EnterWarehouseService : IService<EnterWarehouse>
    {
        IRepository<EnterWarehouse> emp = new EnterWarehouseRepository();
        public int Add(EnterWarehouse obj)
        {
            return emp.Add(obj);
        }

        public bool Delete(int id)
        {
            return emp.Delete(id);
        }

        public List<EnterWarehouse> GetAll()
        {
            return emp.GetAll();
        }

        public EnterWarehouse GetById(int id)
        {
            return emp.GetById(id);
        }

        public bool Update(EnterWarehouse obj)
        {
            return emp.Update(obj);
        }
    }
}
