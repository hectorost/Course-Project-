using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject1.Models
{
    public class ProfileContext : DbContext
    {
        public ProfileContext(DbContextOptions<ProfileContext> options):base(options)
        {

        }

        public DbSet<Login> Logins { get; set; }
        public DbSet<Register> Registration { get; set; }
    }
}
