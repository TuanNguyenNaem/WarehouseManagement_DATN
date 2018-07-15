using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository
{
    public class AccountRepository: IAccountRepository
    {
        WarehouseDbContext db = new WarehouseDbContext();
        public int Add(Account obj)
        {
            db.Accounts.Add(obj);
            return db.SaveChanges();
        }

        public Account CheckLogin(string username, string password)
        {
            var user = db.Accounts.FirstOrDefault(c => c.UserName == username && c.Password == password);
            return user;
        }

        public bool Delete(int id)
        {
            var user = GetById(id);
            db.Accounts.Remove(user);
            return db.SaveChanges() > 0;
        }

        public List<Account> GetAll()
        {

            return db.Accounts.ToList();
        }

        public Account GetById(int id)
        {
            return db.Accounts.FirstOrDefault(c => c.AccountID == id);
        }

        public bool Update(Account obj)
        {
            var user = GetById(obj.AccountID);
            user.UserName = obj.UserName;
            user.Password = obj.Password;
            user.Role = obj.Role;
            return db.SaveChanges() > 0;
        }
    }
}
