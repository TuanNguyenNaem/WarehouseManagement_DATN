using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IContractDetailRepository : IRepository<ContractDetail>
    {
        ContractDetail GetByTwoId(int contractId, int productId);
        bool DeleteByTwoId(int contractId, int productId);
        List<ContractDetail> GetByIdList(int id);
    }
}
