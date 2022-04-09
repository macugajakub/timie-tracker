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
        public static void AddTestData(this DbSet<ApplicationsUser> context)
        {
            context.Add(new ApplicationsUser() { Id = 1, Name = "Edward", Surname = "Kowalski",Password = "xx", Login = "edward.kowalski" });
            context.Add(new ApplicationsUser() { Id = 2, Name = "Genowefa",Surname = "Niekowalska" ,Password = "xx", Login = "genowefa.niekowalska" });
        }

        public static void AddTestData(this DbSet<UserGroup> context)
        {
            context.Add(new UserGroup() { Id = 1, GroupName = "Administrators" });
            context.Add(new UserGroup() { Id = 2, GroupName = "Employees" });
        }

        public static void AddTestData(this DbSet<UserGroupDic> context)
        {
            context.Add(new UserGroupDic() { Id = 1, UserId = 1, GroupId = 1 });    
            context.Add(new UserGroupDic() { Id = 2, UserId = 2, GroupId = 2 });    
        }
    }
}
