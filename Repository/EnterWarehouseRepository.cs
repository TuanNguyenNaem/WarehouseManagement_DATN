using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EnterWarehouseRepository : IRepository<EnterWarehouse>
    {
        WarehouseDbContext db = new WarehouseDbContext();
        public int Add(EnterWarehouse obj)
        {
            db.EnterWarehouses.Add(obj);
            return db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var user = GetById(id);
            db.EnterWarehouses.Remove(user);
            return db.SaveChanges() > 0;
        }

        public List<EnterWarehouse> GetAll()
        {

            return db.EnterWarehouses.ToList();
        }

        public EnterWarehouse GetById(int id)
        {
            return db.EnterWarehouses.FirstOrDefault(c => c.EnterWarehouseID == id);
        }

        public bool Update(EnterWarehouse obj)
        {
            var user = GetById(obj.EnterWarehouseID);
            user.EnterDate = obj.EnterDate;
            user.EmployeeID = obj.EmployeeID;
            user.Status = obj.Status;
            user.Notes = obj.Notes;
            return db.SaveChanges() > 0;
        }
    }
}
