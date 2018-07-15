using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository
{
    public class SupplierRepository : IRepository<Supplier>
    {
        WarehouseDbContext db = new WarehouseDbContext();
        public int Add(Supplier obj)
        {
            db.Suppliers.Add(obj);
            return db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var user = GetById(id);
            db.Suppliers.Remove(user);
            return db.SaveChanges() > 0;
        }

        public List<Supplier> GetAll()
        {

            return db.Suppliers.ToList();
        }

        public Supplier GetById(int id)
        {
            return db.Suppliers.FirstOrDefault(c => c.SupplierID == id);
        }


        public bool Update(Supplier obj)
        {
            var user = GetById(obj.SupplierID);
            user.SupplierName = obj.SupplierName;
            user.Address = obj.Address;
            user.PhoneNumber = obj.PhoneNumber;
            user.AccountNumber = obj.AccountNumber;
            user.TaxCode = obj.TaxCode;
            user.Area = obj.Area;
            user.Email = obj.Email;
            user.Notes = obj.Notes;
            return db.SaveChanges() > 0;
        }
    }
}
