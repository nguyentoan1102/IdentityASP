using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExampleAjax.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("TestAjax")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Student> Students { get; set; }
    }
}