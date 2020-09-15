using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TireStore.Models
{
    public class TireDbContext: DbContext
    {
        public TireDbContext(DbContextOptions<TireDbContext> options)
            : base(options) { }
        public DbSet<Tire> Tires { get; set; }
    }
}
