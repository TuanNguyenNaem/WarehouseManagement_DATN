using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class VipRepository : IRepository<VIP>
    {
        WarehouseDbContext db = new WarehouseDbContext();
        public int Add(VIP obj)
        {
            db.VIPs.Add(obj);
            return db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var user = GetById(id);
            db.VIPs.Remove(user);
            return db.SaveChanges() > 0;
        }

        public List<VIP> GetAll()
        {

            return db.VIPs.ToList();
        }

        public VIP GetById(int id)
        {
            return db.VIPs.FirstOrDefault(c => c.VIPID == id);
        }

        public bool Update(VIP obj)
        {
            var user = GetById(obj.VIPID);
            user.VIPName = obj.VIPName;
            user.Accumulation = obj.Accumulation;
            user.ReduceInvoice = obj.ReduceInvoice;
            user.Unit = obj.Unit;
            return db.SaveChanges() > 0;
        }
    }
}
