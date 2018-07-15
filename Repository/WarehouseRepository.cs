using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class WarehouseRepository : IRepository<Warehouse>
    {
        WarehouseDbContext db = new WarehouseDbContext();
        public int Add(Warehouse obj)
        {
            db.Warehouses.Add(obj);
            return db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var user = GetById(id);
            db.Warehouses.Remove(user);
            return db.SaveChanges() > 0;
        }

        public List<Warehouse> GetAll()
        {

            return db.Warehouses.ToList();
        }

        public Warehouse GetById(int id)
        {
            return db.Warehouses.FirstOrDefault(c => c.ProductID == id);
        }

        public bool Update(Warehouse obj)
        {
            var user = GetById(obj.ProductID);
            user.Quantity = obj.Quantity;
            user.QuantityExactly = obj.QuantityExactly;
            return db.SaveChanges() > 0;
        }
    }
}
