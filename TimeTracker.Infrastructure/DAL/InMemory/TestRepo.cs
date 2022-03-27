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
        private readonly List<TestEntity> _users = new() { new TestEntity() { test = 1}, new TestEntity() { test = 2} };

        
        public async Task<TestEntity> GetValue()
        {
            return _users.FirstOrDefault(e => e.test == 2);   
        }
    }
}
