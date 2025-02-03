using Base_Model.Model.Entities;
using BL_YemekSitesi.Managers.Abstract;
using DAL_YemekSitesi.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_YemekSitesi.Managers.Concreate
{
    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public List<Category> TGetListAll()
        {
            return _categoryRepository.GetListAll();
        }

        public Category TGetByID(int id)
        {
            return _categoryRepository.GetByID(id);
        }


        public void TAdd(Category entity)
        {
           _categoryRepository.Add(entity);
        }

      
        public void TUpdate(Category entity)
        {
            _categoryRepository.Update(entity);
        }

        public void TDelete(Category entity)
        {
           _categoryRepository.Delete(entity);
        }

        public int TCategoryCount()
        {
            return _categoryRepository.CategoryCount();
        }

        public int TActiveCategoryCount()
        {
            return _categoryRepository.ActiveCategoryCount();
        }

        public int TPassiveCategoryCount()
        {
            return _categoryRepository.PassiveCategoryCount();
        }
    }
}
