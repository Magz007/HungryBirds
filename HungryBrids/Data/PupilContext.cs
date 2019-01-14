using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HungryBirds.Models;

namespace HungryBirds.Models
{
    public class PupilContext : DbContext
    {
        public PupilContext (DbContextOptions<PupilContext> options)
            : base(options)
        {
        }

        public DbSet<HungryBirds.Models.Student> Student { get; set; }
        public DbSet<HungryBirds.Models.Meals> Meals { get; set; }
        public DbSet<HungryBirds.Models.Parent> Parent { get; set; }
        public DbSet<HungryBirds.Models.School> School { get; set; }
    }
}
