
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class IRepository<T> where T: class
    {
        T GetByID(int id);
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);   
    }
}
