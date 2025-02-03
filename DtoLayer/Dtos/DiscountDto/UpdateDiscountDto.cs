using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.DiscountDto
{
    public class UpdateDiscountDto
    {
        public int DiscountID { get; set; }

        public string DiscountName { get; set; }

        public string Description { get; set; }

        public int DiscountAmount { get; set; }

        public string DescriptionIamge { get; set; }

        public bool Status { get; set; }
    }
}
