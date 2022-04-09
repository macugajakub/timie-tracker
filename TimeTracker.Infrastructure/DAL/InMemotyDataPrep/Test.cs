using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Domain.Entieties;
using TimeTracker.Infrastructure.DAL.InMemory;

namespace TimeTracker.Infrastructure.DAL.InMemotyDataPrep
{
    public static class Test
    {
        public static void AddTestData(this DbSet<TestEntity> context_TimeTracker)
        {
            context_TimeTracker.Add(new Domain.Entieties.TestEntity() { test = 21});
        }
    }
}
