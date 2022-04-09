using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Domain.Entieties;
using TimeTracker.Infrastructure.DAL.InMemotyDataPrep;

namespace TimeTracker.Infrastructure.DAL.InMemory
{
    public class Context_TimeTracker : DbContext
    {
        public Context_TimeTracker(DbContextOptions<Context_TimeTracker> options) : base(options)
        {
            Users.AddTestData();
            UserGroup.AddTestData();
            UserGroupDic.AddTestData();
            SaveChanges();
        }
        public DbSet<ApplicationsUser> Users { get; set; }
        public DbSet<UserGroup> UserGroup { get; set; }
        public DbSet<UserGroupDic> UserGroupDic { get; set; }
    }
}
