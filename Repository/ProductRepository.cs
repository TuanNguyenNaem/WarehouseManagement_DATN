using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductRepository : IRepository<Product>
    {
        WarehouseDbContext db = new WarehouseDbContext();
        public int Add(Product obj)
        {
            db.Products.Add(obj);
            return db.SaveChanges();
        }

        public bool Delete(int id)
        {
            var user = GetById(id);
            db.Products.Remove(user);
            return db.SaveChanges() > 0;
        }

        public List<Product> GetAll()
        {

            return db.Products.ToList();
        }

        public Product GetById(int id)
        {
            return db.Products.FirstOrDefault(c => c.ProductID == id);
        }
        public List<Product> GetBySupId(int supId)
        {
            return db.Products.ToList().Where(c => c.SupplierID == supId).ToList();
        }

        public bool Update(Product obj)
        {
            var user = GetById(obj.ProductID);
            user.ProductName = obj.ProductName;
            user.CategoryID = obj.CategoryID;
            user.SupplierID = obj.SupplierID;
            user.Color = obj.Color;
            user.Size = obj.Size;
            user.ImportPrice = obj.ImportPrice;
            user.Retail = obj.Retail;
            user.Wholesale = obj.Wholesale;
            user.Notes = obj.Notes;
            return db.SaveChanges() > 0;
        }
    }
}
