using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.ProductDto
{
    public class GetProductDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductPrice { get; set; }
        public string ProductImage { get; set; }

        public bool ProductStatus { get; set; }
        public int CategoryID { get; set; }
    }
}
