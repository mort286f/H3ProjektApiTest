using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace H3ProjektAPITest.Models
{
    //The DB Context for mapping data and making changes to the database
    public class LoginDBContext : DbContext
    {
        public DbSet<DbUser> Users { get; set; }
        public DbSet<UserLog> UserLogs { get; set; }
        public LoginDBContext(DbContextOptions<LoginDBContext> options): base(options)
        {
            this.Database.Migrate();
        }
    }
}
