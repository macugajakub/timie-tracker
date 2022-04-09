using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Domain.Entieties;
using TimeTracker.Domain.Repository;

namespace TimeTracker.Infrastructure.DAL.InMemory
{
    public class TestRepo : ITestRepo
    {

        private readonly Context_TimeTracker _context;
        public TestRepo(Context_TimeTracker context)
        {
            _context = context;
        }


        public async Task<TestEntity> GetValue()
        {
            return _context.TestEntities.FirstOrDefault(e => e.test == 21);   
        }
    }
}
