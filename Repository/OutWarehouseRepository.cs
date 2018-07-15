using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class OutWarehouseRepository : IRepository<OutWarehouse>
    {
        WarehouseDbContext db = new WarehouseDbContext();
        public int Add(OutWarehouse obj)
        {
            db.OutWarehouses.Add(obj);
            return db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var user = GetById(id);
            db.OutWarehouses.Remove(user);
            return db.SaveChanges() > 0;
        }

        public List<OutWarehouse> GetAll()
        {

            return db.OutWarehouses.ToList();
        }

        public OutWarehouse GetById(int id)
        {
            return db.OutWarehouses.FirstOrDefault(c => c.OutWarehouseID == id);
        }

        public bool Update(OutWarehouse obj)
        {
            var user = GetById(obj.OutWarehouseID);
            user.OutDate = obj.OutDate;
            user.EmployeeID = obj.EmployeeID;
            user.Status = obj.Status;
            user.Notes = obj.Notes;
            return db.SaveChanges() > 0;
        }
    }
}
