﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.FeatureDto
{
    public class UpdateFeatureDto
    {
        public int FeatureID { get; set; }

        public string FeatureName1 { get; set; }

        public string FeatureName2 { get; set; }

        public string FeatureName3 { get; set; }

        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
    }
}
