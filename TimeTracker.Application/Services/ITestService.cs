using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Application.DTO;

namespace TimeTracker.Application.Services
{
    public interface ITestService
    {
        Task<TestEntityDto> GetAsync();
    }
}
