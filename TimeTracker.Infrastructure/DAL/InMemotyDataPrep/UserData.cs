using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Domain.Entieties;

namespace TimeTracker.Infrastructure.DAL.InMemotyDataPrep
{
    public static class UserData
    {
        public static void AddTestData(this DbSet<User> context_TimeTracker)
        {
            context_TimeTracker.Add(new User() { Id = 1, Name = "dsa", Password = "xx" });
            context_TimeTracker.Add(new User() { Id = 2, Name = "dsa", Password = "xx" });
        }
    }
}
