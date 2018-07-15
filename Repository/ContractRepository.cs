using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ContractRepository : IRepository<Contract>
    {
        WarehouseDbContext db = new WarehouseDbContext();
        public int Add(Contract obj)
        {
            db.Contracts.Add(obj);
            return db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var user = GetById(id);
            db.Contracts.Remove(user);
            return db.SaveChanges() > 0;
        }

        public List<Contract> GetAll()
        {

            return db.Contracts.ToList();
        }

        public Contract GetById(int id)
        {
            return db.Contracts.FirstOrDefault(c => c.ContractID == id);
        }

        public bool Update(Contract obj)
        {
            var user = GetById(obj.ContractID);
            user.EmployeeID = obj.EmployeeID;
            user.SupplierID = obj.SupplierID;
            user.CreateDate = obj.CreateDate;
            user.DeliveryDate = obj.DeliveryDate;
            user.Status = obj.Status;
            user.Notes = obj.Notes;
            return db.SaveChanges() > 0;
        }
    }
}
