using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreMVCWebApp.Models
{
    public class CoreMVCWebAppContext : DbContext
    {
        public CoreMVCWebAppContext (DbContextOptions<CoreMVCWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<CoreMVCWebApp.Models.Movie> Movie { get; set; }
    }
}
