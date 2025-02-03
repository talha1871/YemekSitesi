using Base_Model.Model.Entities;
using Base_Model.Model.ViewModels;
using DAL_YemekSitesi.Context;
using DAL_YemekSitesi.GenericRepositories.Concreate;
using DAL_YemekSitesi.Repositories.Abstract;
using DtoLayer.Dtos.ProductDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_YemekSitesi.Repositories.Concreate
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(SignalRContext context) : base(context)
        {
        }

        

        public List<Product> GetProductsWithCategories()
        {
            SignalRContext context = new SignalRContext();
            var product = context.Products.Include("Category").ToList();
            return product;





        }

        public int ProductCount()
        {
            using (var context = new SignalRContext())
            { 
                return context.Products.Count();
            }
        }

        public int ProductCountByCategoryNameAsHamburger()
        {
            using (var ctx = new SignalRContext())

            return ctx.Products.Where(x => x.CategoryID == (ctx.Categorys.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryID).FirstOrDefault())).Count();
        }

        public int ProductCountByCategoryNameAsDrink()
        {
            using(var ctx = new SignalRContext())
            {
                return ctx.Products.Where(x => x.CategoryID == (ctx.Categorys.Where(y => y.CategoryName == "Drink").Select(z => z.CategoryID).FirstOrDefault())).Count();          
            }
        }

        public decimal ProductAvgPrice()
        {
            using (var ctz = new SignalRContext())
            {
                var price = (double)(ctz.Products.Average(x => x.ProductPrice));
                return ((decimal)price);
            }
            
        }

        public string ProductNameByMaxPrice()
        {
            using (var ctx = new SignalRContext())
            {
                return ctx.Products.Where(x => x.ProductPrice == (ctx.Products.Max(y => y.ProductPrice))).Select(z => z.ProductName).FirstOrDefault();
            }
        }

        public string ProductNameByMinPrice()
        {
            using (var ctx = new SignalRContext())
            return ctx.Products.Where(x => x.ProductPrice == (ctx.Products.Min(y => y.ProductPrice))).Select(z => z.ProductName).FirstOrDefault();
        }

        public decimal ProductAvgPriceForHamburger()
        {
            using (var ctx = new SignalRContext())
            {
                return (decimal)(ctx.Products.Where(x => x.CategoryID == (ctx.Categorys.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryID).FirstOrDefault())).Average( w => w.ProductPrice));

            }

        }


    }
               


}
