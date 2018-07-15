using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CategoryService : IService<Category>
    {
        IRepository<Category> emp = new CategoryRepository();
        public int Add(Category obj)
        {
            return emp.Add(obj);
        }

        public bool Delete(int id)
        {
            return emp.Delete(id);
        }

        public List<Category> GetAll()
        {
            return emp.GetAll();
        }

        public Category GetById(int id)
        {
            return emp.GetById(id);
        }

        public bool Update(Category obj)
        {
            return emp.Update(obj);
        }
    }
}
