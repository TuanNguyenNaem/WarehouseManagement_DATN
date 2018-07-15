using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class VipService : IService<VIP>
    {
        IRepository<VIP> emp = new VipRepository();
        public int Add(VIP obj)
        {
            return emp.Add(obj);
        }

        public bool Delete(int id)
        {
            return emp.Delete(id);
        }

        public List<VIP> GetAll()
        {
            return emp.GetAll();
        }

        public VIP GetById(int id)
        {
            return emp.GetById(id);
        }

        public bool Update(VIP obj)
        {
            return emp.Update(obj);
        }
    }
}
