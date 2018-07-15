using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CustomerService : IService<Customer>
    {
        IRepository<Customer> emp = new CustomerRepository();
        public int Add(Customer obj)
        {
            return emp.Add(obj);
        }

        public bool Delete(int id)
        {
            return emp.Delete(id);
        }

        public List<Customer> GetAll()
        {
            return emp.GetAll();
        }

        public Customer GetById(int id)
        {
            return emp.GetById(id);
        }

        public bool Update(Customer obj)
        {
            return emp.Update(obj);
        }
    }
}
