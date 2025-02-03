﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Model.Model.Entities
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string Location { get; set; }

        public string PhoneNumber { get; set; }

        public string ContactMail { get; set; }
        public string FooterTitle { get; set; }

        public string FooterDescription { get; set; }
        public string OpenDays { get; set; }
        public string OpenDaysDescription { get; set; }
        public string OpenHours { get; set; }
    }
}
