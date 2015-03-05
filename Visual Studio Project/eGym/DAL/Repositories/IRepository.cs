using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
<<<<<<< HEAD
=======
using System.Threading.Tasks;
using EL;
>>>>>>> 971ef86cf09a1915fab344afbc3097230234f2f3

namespace DAL.Repositories
{
    public interface IRepository<T>
    {
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        IEnumerable<T> GetAll();
<<<<<<< HEAD
        T GetById(int id);
=======
>>>>>>> 971ef86cf09a1915fab344afbc3097230234f2f3
        void Save();
        void Clear();
    }
}
