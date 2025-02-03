using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL_YemekSitesi.GenericRepositories.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetByID(int id);
        List<T> GetListAll();
    }
}
