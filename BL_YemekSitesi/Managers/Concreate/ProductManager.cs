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
    public class ProductManager : IProductManager
    {

        private readonly IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> TGetListAll()
        {
            return _productRepository.GetListAll();
        }
        public Product TGetByID(int id)
        {
            return _productRepository.GetByID(id);
        }


        public void TAdd(Product entity)
        {
            _productRepository.Add(entity);
        }

        public void TDelete(Product entity)
        {
           _productRepository.Delete(entity);
        }

        
        public void TUpdate(Product entity)
        {
            _productRepository.Update(entity);
        }

        public List<Product> TGetProductWithCategories()
        {
            return _productRepository.GetProductsWithCategories();
        }

        public int TProductCount()
        {
            return _productRepository.ProductCount();
        }

        public int TProductCountByCategoryNameAsHamburger()
        {
            return _productRepository.ProductCountByCategoryNameAsHamburger();
        }

        public int TProductCountByCategoryNameAsDrink()
        {
            return _productRepository.ProductCountByCategoryNameAsDrink();
        }

        public decimal TProductAvgPrice()
        {
            return _productRepository.ProductAvgPrice();
        }

        public string TProductNameByMaxPrice()
        {
            return _productRepository.ProductNameByMaxPrice();
        }

        public string TProductNameByMinPrice()
        {
            return (_productRepository.ProductNameByMinPrice());
        }

        public decimal TProductAvgPriceForHamburger()
        {
           return (_productRepository.ProductAvgPriceForHamburger());
        }
    }
}
