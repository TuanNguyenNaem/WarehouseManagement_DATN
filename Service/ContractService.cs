using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ContractService : IService<Contract>
    {
        IRepository<Contract> emp = new ContractRepository();
        public int Add(Contract obj)
        {
            return emp.Add(obj);
        }

        public bool Delete(int id)
        {
            return emp.Delete(id);
        }

        public List<Contract> GetAll()
        {
            return emp.GetAll();
        }

        public Contract GetById(int id)
        {
            return emp.GetById(id);
        }

        public bool Update(Contract obj)
        {
            return emp.Update(obj);
        }
    }
}
