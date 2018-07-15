using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class WarehouseService : IService<Warehouse>
    {
        IRepository<Warehouse> emp = new WarehouseRepository();
        public int Add(Warehouse obj)
        {
            return emp.Add(obj);
        }

        public bool Delete(int id)
        {
            return emp.Delete(id);
        }

        public List<Warehouse> GetAll()
        {
            return emp.GetAll();
        }

        public Warehouse GetById(int id)
        {
            return emp.GetById(id);
        }

        public bool Update(Warehouse obj)
        {
            return emp.Update(obj);
        }
    }
}
