using Microsoft.EntityFrameworkCore;
using SOLID.Models;
using System.Collections.Generic;

namespace SOLID.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<User> Users { get; set; }

    }
}
  