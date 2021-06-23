using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winformmvp.Model;

namespace winformmvp.Data
{
    class PetrolContext:DbContext
    {
        public PetrolContext():base("PetrolDb")
        {

        }
        public DbSet <Petrol>Petrols { get; set; }
        public DbSet <Payment>Payments { get; set; }
    }
}
