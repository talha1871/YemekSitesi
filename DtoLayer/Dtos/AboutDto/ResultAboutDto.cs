using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.AboutDto
{
    public class ResultAboutDto
    {
        public int AboutID { get; set; }
        public string AboutName { get; set; }
        public string AboutImage { get; set; }

        public string AboutDescription { get; set; }
    }
}
