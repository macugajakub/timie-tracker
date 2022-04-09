using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Domain.Entieties
{
    public class UserGroup
    {
        [Key]
        public int Id { get; set; }
        public string GroupName { get; set; }
    }
}
