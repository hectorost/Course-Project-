﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject1.Models
{
    public class Login
    {
        [Key]
        public Guid LoginId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
