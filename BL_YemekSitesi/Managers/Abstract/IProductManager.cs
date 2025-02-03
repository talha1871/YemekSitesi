using Base_Model.Model.Entities;
using BL_YemekSitesi.Managers.GenericManager.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_YemekSitesi.Managers.Abstract
{
    public interface IProductManager  : IGenericManager<Product>
    { 
        public List<Product> TGetProductWithCategories();

        public int TProductCount();

        public int TProductCountByCategoryNameAsHamburger();

        public int TProductCountByCategoryNameAsDrink();
        public decimal TProductAvgPrice();

        public string TProductNameByMaxPrice();

        public string TProductNameByMinPrice();

        public decimal TProductAvgPriceForHamburger();
    }
}
