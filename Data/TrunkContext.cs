using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Trunk.Models
{
    public class TrunkContext : DbContext
    {
        public TrunkContext (DbContextOptions<TrunkContext> options)
            : base(options)
        {
        }

        public DbSet<Trunk.Models.Inventory> Inventory { get; set; }
    }
}
