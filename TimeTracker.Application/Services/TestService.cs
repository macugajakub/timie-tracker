using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Application.DTO;
using TimeTracker.Domain.Repository;

namespace TimeTracker.Application.Services
{
    internal class TestService : ITestService
    {
      
        private readonly ITestRepo _userRepository;

        public TestService(ITestRepo repo)
        {
            _userRepository = repo;
        }

        public async Task<TestEntityDto> GetAsync()
        {
            var test = await _userRepository.GetValue();
            return new TestEntityDto() { test = test.test };
        }
    }
}
