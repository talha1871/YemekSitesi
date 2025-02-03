
using Base_Model.Model.Entities;
using DAL_YemekSitesi.GenericRepositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_YemekSitesi.Repositories.Abstract
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public List<Product> GetProductsWithCategories();
        public int ProductCount();

        public int ProductCountByCategoryNameAsHamburger();

        public int ProductCountByCategoryNameAsDrink();

        public decimal ProductAvgPrice();

        public string ProductNameByMaxPrice();

        public string ProductNameByMinPrice();

        public decimal ProductAvgPriceForHamburger();
    }
}
