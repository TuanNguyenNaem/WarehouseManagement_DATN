using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeRepository : IRepository<Employee>
    {
        WarehouseDbContext db = new WarehouseDbContext();
        public int Add(Employee obj)
        {
            db.Employees.Add(obj);
            return db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var user = GetById(id);
            db.Employees.Remove(user);
            return db.SaveChanges() > 0;
        }

        public List<Employee> GetAll()
        {

            return db.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return db.Employees.FirstOrDefault(c => c.EmployeeID == id);
        }

        public bool Update(Employee obj)
        {
            var user = GetById(obj.EmployeeID);
            user.EmployeeName = obj.EmployeeName;
            user.BirthDate = obj.BirthDate;
            user.Address = obj.Address;
            user.HireDate = obj.HireDate;
            user.PhoneNumber = obj.PhoneNumber;
            user.Gender = obj.Gender;
            user.Status = obj.Status;
            user.Notes = obj.Notes;
            return db.SaveChanges() > 0;
        }
    }
}
