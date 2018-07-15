using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService : IService<Product>
    {
        ProductRepository emp = new ProductRepository();
        public int Add(Product obj)
        {
            return emp.Add(obj);
        }

        public bool Delete(int id)
        {
            return emp.Delete(id);
        }

        public List<Product> GetAll()
        {
            return emp.GetAll();
        }

        public Product GetById(int id)
        {
            return emp.GetById(id);
        }

        public bool Update(Product obj)
        {
            return emp.Update(obj);
        }
        public List<Product> GetBySupId(int subId)
        {
            return emp.GetBySupId(subId);
        }
    }
}
