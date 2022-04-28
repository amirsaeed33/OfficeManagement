using ManagementSytstem.Database.Auth;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSytstem.Database
{
    class MyModel:DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
