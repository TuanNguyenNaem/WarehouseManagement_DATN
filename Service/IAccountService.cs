using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;
namespace Service
{
    public interface IAccountService : IService<Account>
    {
        Account CheckLogin(string username, string password);
    }
}
