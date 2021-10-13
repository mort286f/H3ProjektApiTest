using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H3ProjektAPITest.Models
{
    public interface ILoginDBContext
    {
        DbSet<DbUser> Users { get; }
        DbSet<UserLog> UserLogs { get; }
        void MarkAsModified(User user);
    }
}
