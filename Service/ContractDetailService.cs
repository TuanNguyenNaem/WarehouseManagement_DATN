using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ContractDetailService : IContractDetailService
    {
        IContractDetailRepository oder = new ContracDetailRepository();
        public int Add(ContractDetail obj)
        {
            return oder.Add(obj);
        }

        public bool Delete(int id)
        {
            return oder.Delete(id);
        }

        public bool DeleteByTwoId(int orderId, int productId)
        {
            return oder.DeleteByTwoId(orderId, productId);
        }

        public List<ContractDetail> GetAll()
        {
            return oder.GetAll();
        }

        public ContractDetail GetById(int id)
        {
            return oder.GetById(id);
        }
        public List<ContractDetail> GetByIdList(int id)
        {
            return oder.GetByIdList(id);
        }

        public ContractDetail GetByTwoId(int orderId, int productId)
        {
            return oder.GetByTwoId(orderId, productId);
        }

        public bool Update(ContractDetail obj)
        {
            return oder.Update(obj);
        }
    }
}
