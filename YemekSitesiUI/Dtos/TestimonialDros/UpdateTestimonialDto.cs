﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekSitesiUI.Dtos.TestimonialDtos
{
    public class UpdateTestimonialDto
    {
        public int TestimonialID { get; set; }
        public string TestimonialName { get; set; }
        public string TestimonialDescription { get; set; }

        public string TestimonialTitle { get; set; }

        public string TestimonialImage { get; set; }

        public bool TestimonialStatus { get; set; }
    }
}
