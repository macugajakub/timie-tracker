using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Domain.Entieties;

namespace TimeTracker.Domain.Repository
{
    public interface ITestRepo
    {
        Task<TestEntity> GetValue();
    }
}
