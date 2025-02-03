using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.CategoryDto
{
    public class CreateCategoryDto
    {
       
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool Status { get; set; }
    }
}
