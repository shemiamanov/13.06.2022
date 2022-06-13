using EnAutos_backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnAutos_backend.DAL
{
    public class ApDbContext : DbContext
    {
        public ApDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Car> cars { get; set; }
        public DbSet<Catecori> catecoris { get; set; }
    }
}
