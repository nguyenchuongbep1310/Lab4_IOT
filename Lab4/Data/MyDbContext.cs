using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext (DbContextOptions options): base(options) { }

        #region
        public DbSet<ThietBi> ThietBis { get; set; }
        public DbSet<Loai> Loais { get; set; }
        #endregion

    }
}
