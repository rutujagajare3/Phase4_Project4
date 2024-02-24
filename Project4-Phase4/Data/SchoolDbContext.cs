using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project4_Phase4.Models;

namespace Project4_Phase4.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext (DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project4_Phase4.Models.Student> Student { get; set; } = default!;
    }
}
