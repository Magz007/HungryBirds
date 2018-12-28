using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HungryBirds.Models
{
    public class PupilContext : DbContext
    {
        public PupilContext (DbContextOptions<PupilContext> options)
            : base(options)
        {
        }

        public DbSet<HungryBirds.Models.Student> Student { get; set; }
    }
}
