using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Identity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity.Context
{
    public class EfContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public EfContext(DbContextOptions<EfContext> options) : base(options)
        {

        }
    }
}
