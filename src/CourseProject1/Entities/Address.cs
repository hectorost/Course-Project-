﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject1.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
