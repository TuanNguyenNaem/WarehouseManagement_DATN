using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;

namespace Service
{
    public class AccountService : IAccountService
    {
        IAccountRepository accountRepository = new AccountRepository();
        public int Add(Account obj)
        {
            return accountRepository.Add(obj);
        }

        public Account CheckLogin(string username, string password)
        {
            return accountRepository.CheckLogin(username, password);
        }

        public bool Delete(int id)
        {
            return accountRepository.Delete(id);
        }

        public List<Account> GetAll()
        {
            return accountRepository.GetAll();
        }

        public Account GetById(int id)
        {
            return accountRepository.GetById(id);
        }

        public bool Update(Account obj)
        {
            return accountRepository.Update(obj);
        }
    }
}
