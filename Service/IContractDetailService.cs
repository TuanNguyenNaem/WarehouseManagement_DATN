using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IContractDetailService : IService<ContractDetail>
    {
        ContractDetail GetByTwoId(int contractId, int productId);
        bool DeleteByTwoId(int contractId, int productId);
        List<ContractDetail> GetByIdList(int id);
    }
}
