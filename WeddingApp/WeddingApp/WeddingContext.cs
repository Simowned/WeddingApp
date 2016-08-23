using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WeddingApp
{
    public class WeddingContext : DbContext
    {
        public DbSet<Persoon> Personen { get; set; }
    }
}
