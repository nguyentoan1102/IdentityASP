using IdentityASP.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IdentityASP.Infrastructure
{
    public class AppIdentityDbContext : IdentityDbContext
    {
        public AppIdentityDbContext() : base("IdentityDb")
        {
        }

        public static AppIdentityDbContext Create() => new AppIdentityDbContext();
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
    }

}