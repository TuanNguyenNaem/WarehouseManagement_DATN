using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IService<T>
    {
        List<T> GetAll();
        T GetById(int id);
        int Add(T obj);
        bool Update(T obj);
        bool Delete(int id);
    }
}
