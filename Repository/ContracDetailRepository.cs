using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ContracDetailRepository : IContractDetailRepository
    {
        WarehouseDbContext db = new WarehouseDbContext();
        public int Add(ContractDetail obj)
        {
            db.ContractDetails.Add(obj);
            return db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var temp = db.ContractDetails.ToList().Where(c => c.ContractID == id);
            foreach (var item in temp)
            {
                db.ContractDetails.Remove(item);
            }
            return db.SaveChanges() > 0;
        }

        public bool DeleteByTwoId(int contractId, int productId)
        {
            var obj = GetByTwoId(contractId, productId);
            db.ContractDetails.Remove(obj);
            return db.SaveChanges() > 0;
        }

        public List<ContractDetail> GetAll()
        {

            return db.ContractDetails.ToList();
        }

        public ContractDetail GetById(int id)
        {
            return db.ContractDetails.FirstOrDefault(c => c.ContractID == id);
        }
        public List<ContractDetail> GetByIdList(int id)
        {
            return db.ContractDetails.ToList().Where(c => c.ContractID == id).ToList();
        }

        public ContractDetail GetByTwoId(int contractId, int productId)
        {
            return db.ContractDetails.FirstOrDefault(c => c.ContractID == contractId && c.ProductID == productId);
        }

        public bool Update(ContractDetail obj)
        {
            var user = GetByTwoId(obj.ContractID, obj.ProductID);
            user.Quantity = obj.Quantity;
            user.Notes = obj.Notes;
            return db.SaveChanges() > 0;
        }
    }
}
