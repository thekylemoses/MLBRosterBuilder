#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MLBRosterBuilder.Models;

namespace MLBRosterBuilder.Data
{
    public class MLBRosterBuilderContext : DbContext
    {
        public MLBRosterBuilderContext (DbContextOptions<MLBRosterBuilderContext> options)
            : base(options)
        {
        }

        public DbSet<MLBRosterBuilder.Models.Player> Player { get; set; }
    }
}
