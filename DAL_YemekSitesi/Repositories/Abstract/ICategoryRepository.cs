using Base_Model.Model.Entities;
using DAL_YemekSitesi.GenericRepositories.Abstract;

namespace DAL_YemekSitesi.Repositories.Abstract
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
        public int CategoryCount();

        public int ActiveCategoryCount();
        public int PassiveCategoryCount();
    }
}
