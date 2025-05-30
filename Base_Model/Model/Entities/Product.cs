﻿namespace Base_Model.Model.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductPrice { get; set; }
        public string ProductImage { get; set; }

        public bool ProductStatus { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}
