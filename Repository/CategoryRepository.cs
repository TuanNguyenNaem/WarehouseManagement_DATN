using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        WarehouseDbContext db = new WarehouseDbContext();
        public int Add(Category obj)
        {
            db.Categories.Add(obj);
            return db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var user = GetById(id);
            db.Categories.Remove(user);
            return db.SaveChanges() > 0;
        }

        public List<Category> GetAll()
        {

            return db.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return db.Categories.FirstOrDefault(c => c.CategoryID == id);
        }

        public bool Update(Category obj)
        {
            var user = GetById(obj.CategoryID);
            user.CategoryName = obj.CategoryName;
            user.Notes = obj.Notes;
            return db.SaveChanges() > 0;
        }
    }
}
