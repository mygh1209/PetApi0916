using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PetApi.Models
{
    public class PetsContext : DbContext
    {
        public PetsContext (DbContextOptions<PetsContext> options)
            : base(options)
        {
        }

        public DbSet<PetApi.Models.Pet> Pet { get; set; }
    }
}
