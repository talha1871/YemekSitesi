
using Base_Model.Model.Entities;
using DAL_YemekSitesi.Context;
using DAL_YemekSitesi.GenericRepositories.Concreate;
using DAL_YemekSitesi.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_YemekSitesi.Repositories.Concreate
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(SignalRContext context) : base(context)
        {
        }

        public int ActiveCategoryCount()
        {
            using (var context = new SignalRContext()) 
            { 
                return context.Categorys.Where(x=>x.Status==true).Count();

            }
        }

        public int CategoryCount()
        {
            using (var context = new SignalRContext())
            { 
                return context.Categorys.Count();
            }
        }

        public int PassiveCategoryCount()
        {
            using ( var context = new SignalRContext())
            {
                return context.Categorys.Where(x=>x.Status == false).Count();
            }
        }
    }
}
