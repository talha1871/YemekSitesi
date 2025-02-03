using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Model.Model.Entities
{
    public class Order
    {
        public int OrderID {  get; set; }
        public string TableNumber { get; set; }

        public string OrderDescription { get; set; }

        public DateTime OrderDate { get; set; }

        
        public decimal TotalOrderPrice { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
