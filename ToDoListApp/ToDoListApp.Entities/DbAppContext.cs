using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp.Entities
{
    public class DbAppContext : DbContext
    {
        public DbAppContext() : base(nameOrConnectionString: "databaseConnection")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Notice> Notices { get; set; }
    }
}
