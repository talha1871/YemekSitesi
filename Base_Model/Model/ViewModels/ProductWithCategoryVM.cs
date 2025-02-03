using Base_Model.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Model.Model.ViewModels
{
    public class ProductWithCategoryVM
    {
        public Product Products { get; set; }

        public List<Category> Categorys { get; set; }
    }
}
