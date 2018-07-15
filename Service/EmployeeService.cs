using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class EmployeeService : IService<Employee>
    {
        IRepository<Employee> emp = new EmployeeRepository();
        public int Add(Employee obj)
        {
            return emp.Add(obj);
        }

        public bool Delete(int id)
        {
            return emp.Delete(id);
        }

        public List<Employee> GetAll()
        {
            return emp.GetAll();
        }

        public Employee GetById(int id)
        {
            return emp.GetById(id);
        }

        public bool Update(Employee obj)
        {
            return emp.Update(obj);
        }
    }
}
