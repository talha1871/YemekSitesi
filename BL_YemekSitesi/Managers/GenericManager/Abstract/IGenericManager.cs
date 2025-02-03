using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_YemekSitesi.Managers.GenericManager.Abstract
{
    public interface IGenericManager<T> where T : class
    {
        public void TAdd(T entity);
        public void TDelete(T entity);
        public void TUpdate(T entity);
        public T TGetByID(int id);
        public List<T> TGetListAll();
    }
}
