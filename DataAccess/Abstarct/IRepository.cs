using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstarct
{
    public interface IRepository<T>
    {
        T GetById(int id);
        T Get(int id);  
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
