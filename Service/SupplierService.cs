using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class SupplierService : IService<Supplier>
    {
        IRepository<Supplier> emp = new SupplierRepository();
        public int Add(Supplier obj)
        {
            return emp.Add(obj);
        }

        public bool Delete(int id)
        {
            return emp.Delete(id);
        }

        public List<Supplier> GetAll()
        {
            return emp.GetAll();
        }

        public Supplier GetById(int id)
        {
            return emp.GetById(id);
        }

        public bool Update(Supplier obj)
        {
            return emp.Update(obj);
        }
    }
}
