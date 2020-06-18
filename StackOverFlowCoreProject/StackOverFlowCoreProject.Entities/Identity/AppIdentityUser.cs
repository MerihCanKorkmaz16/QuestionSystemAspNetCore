using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using StackOverFlowCoreProject.Entities.Concrete;

namespace StackOverFlowCoreProject.Entities.Identity
{
    public class AppIdentityUser: IdentityUser
    {
        public AppIdentityUser()
        {
            Soru = new HashSet<Soru>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime UserCreatedDate { get; set; }
        public virtual ICollection<Soru> Soru { get; set; }
    }
}
