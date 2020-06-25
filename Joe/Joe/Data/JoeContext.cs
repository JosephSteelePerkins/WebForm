using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Joe.Models;

namespace Joe.Data
{
    public class JoeContext : DbContext
    {
        public JoeContext (DbContextOptions<JoeContext> options)
            : base(options)
        {
        }

        public DbSet<Joe.Models.Movie> Movie { get; set; }
    }
}
